using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAttackState : IMonsterState
{
    private MonsterBase _monster;
    private float _atkCoolTime;
    private float _lastAttackTime;

    public MonsterAttackState(MonsterBase owner)
    {
        _monster = owner;
        _lastAttackTime = Time.time;
        _atkCoolTime = _monster.BaseAtkCoolTime;
        //_monster.PerformAttack();
    }

    public void Enter()
    {
    
    }

    public void Update()
    {
        if(Time.time >= _lastAttackTime + _atkCoolTime)
        {
            //_monster.StateMachine.ChangeState(new MonsterIdleState(_monster));
        }
    }

    public void Exit()
    {

    }


}
