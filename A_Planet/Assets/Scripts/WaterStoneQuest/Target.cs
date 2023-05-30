using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Target : MonoBehaviour
{
    public float health = 5.0f;
    public int pointValue;

    public ParticleSystem DestroyedEffect;
    
    public bool Destroyed => m_Destroyed;

    bool m_Destroyed = false;
    float m_CurrentHealth;

    void Start()
    {
    //     if(DestroyedEffect)
    //         PoolSystem.Instance.InitPool(DestroyedEffect, 16);
        
    //     m_CurrentHealth = health;
    //     if(IdleSource != null)
    //         IdleSource.time = Random.Range(0.0f, IdleSource.clip.length);
    //
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, 10000f))
            {
                health -= 1;
            }
        }

        if(health==0) {
            Destroy(gameObject);
        }
    }
}
