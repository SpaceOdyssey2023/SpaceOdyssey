using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoDamager : MonoBehaviour
{//토네이도를 
 // Start is called before the first frame update
    public int damage = 20;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Player")
        {
            Debug.Log("Damaged by tornado! -20 HP");
            collider.gameObject.GetComponent<Player>().TakeDamage(damage);
        }
    }
}
