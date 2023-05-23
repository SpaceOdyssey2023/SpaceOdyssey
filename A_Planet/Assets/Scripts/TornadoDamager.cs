using UnityEngine;

public class TornadoDamager : MonoBehaviour
{
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