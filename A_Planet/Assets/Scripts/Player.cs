using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : LivingEntity
{
    // ������ �ޱ�
    public override void TakeDamage(int damage)
    {
        // ������ �˾� ��

        // LivingEntity ��ũ��Ʈ���� ��ӹ��� TakeDamage() �޼��� ȣ��
        base.TakeDamage(damage);
    }

    // ���� ó��
    protected override void Die()
    {
        // ���� �˾� ��

        // LivingEntity ��ũ��Ʈ���� ��ӹ��� Die() �޼��� ȣ��
        base.Die();
    }
}
