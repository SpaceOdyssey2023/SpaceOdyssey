using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

// Makes objects float up & down while gently spinning.
public class FloatingSphere : MonoBehaviour {
// User Inputs
    public float degreesPerSecond = 15.0f;
    public float amplitude = 0.2f;
    public float frequency = 1f;

    // Position Storage Variables
    Vector3 posOffset = new Vector3 ();
    Vector3 tempPos = new Vector3 ();

    // Use this for initialization
    void Start () {
    // Store the starting position & rotation of the object
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update () {
    // Spin object around Y-Axis
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);

        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;

        if(Input.GetMouseButtonDown(1))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if(Physics.Raycast(ray, out hit, 10000f))
                {
                    Destroy(gameObject);
                }
            }
    }
}