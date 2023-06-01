using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Core : MonoBehaviour
{

    public int maxHp = 100;
    private int hp;

    public UnityEvent<string> onHpChanged;
    public UnityEvent OnHit;
    public UnityEvent OnDestroy;

    private static Core instance;
    public static Core Instance
    {

        get
        {
            if (instance == null) instance = GameObject.FindObjectOfType<Core>();
                return instance;
            
        }
    }
    private void Awake()
    {
        instance = this;        
    }
    private void OnEnable()
    {
        hp = maxHp;
        UpDateUI();
        
    }
 /*
    public void OnTriggerEnter(Collider other)
    {
        var tornado = other.GetComponent<TornadoRandomMove>();
        if(tornado != null)
        {
            OnHit?.Invoke();
            DecreaseHP(1);
        }
    }
 */
    private void DecreaseHP(int amount)
    {
        if (hp <= 0)
        {
            return;
          
        }
        hp -= amount;
        if (hp <= 0)
        {
            hp = 0;
            OnDestroy?.Invoke();
        }
        UpDateUI();
    }

    private void UpDateUI()
    {
        onHpChanged?.Invoke($"HP: {hp}");
    }
}
