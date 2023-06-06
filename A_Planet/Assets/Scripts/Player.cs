using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : LivingEntity
{
    // 데미지 받기
    public override void TakeDamage(int damage)
    {
        // 데미지 팝업 등

        // LivingEntity 스크립트에서 상속받은 TakeDamage() 메서드 호출
        base.TakeDamage(damage);
    }

    // 죽음 처리
    protected override void Die()
    {
        // 죽음 팝업 등

        // LivingEntity 스크립트에서 상속받은 Die() 메서드 호출
        base.Die();
    }
}
