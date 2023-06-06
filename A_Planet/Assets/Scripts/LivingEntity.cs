using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingEntity : MonoBehaviour
{
    public int initialHealth = 100;       // 시작 체력
    public int currentHealth;             // 남은 체력
    public bool dead;                     // 죽음 여부

    // 체력 초기화
    private void OnEnable()
    {
        currentHealth = initialHealth;
        dead = false;
    }

    // 데미지 받기
    public virtual void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0 && !dead)
        {
            Die();
        }
    }

    // 죽음 처리
    protected virtual void Die()
    {
        dead = true;

        // gameObject.SetActive(false);
    }
}
