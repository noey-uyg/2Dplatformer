using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMonster : MonsterBase
{
    public override void Initialize(MonsterInfo data)
    {
        _monsterID = data.id;
        _name = data.name;
        _monsterType = (MonsterType)data.monsterType;
        _attackType = (DamageType)data.baseAtkType;
        _moveType = (MonsterMoveType)data.moveType;
        _isBodyHitDam = data.bodyHitDam;
        _baseHP = data.baseHp;
        _baseAtk = data.baseAtk;
        _baseAtkCoolTime = data.atkCD;
        _moveSpeed *= 1.25f;
    }

    public override void PerFormAttack()
    {
        Debug.Log("Boss Atk");
    }
}
