using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingEntity : MonoBehaviour
{
    public int initialHealth = 100;       // ���� ü��
    public int currentHealth;             // ���� ü��
    public bool dead;                     // ���� ����

    // ü�� �ʱ�ȭ
    private void OnEnable()
    {
        currentHealth = initialHealth;
        dead = false;
    }

    // ������ �ޱ�
    public virtual void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0 && !dead)
        {
            Die();
        }
    }

    // ���� ó��
    protected virtual void Die()
    {
        dead = true;

        // gameObject.SetActive(false);
    }
}
