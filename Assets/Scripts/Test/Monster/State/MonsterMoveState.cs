using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMoveState : IMonsterState
{
    private MonsterBase _monster;

    public MonsterMoveState(MonsterBase owner) {  _monster = owner; }

    public void Enter()
    {
        
    }

    public void Update()
    {
        //이동

        //플레이어 사정거리 이내 접근 시 공격
        if (_monster.CheckPlayerInRange())
        {
            Debug.Log("사정거리 이내");
            _monster.StateMachine.ChangeState(new MonsterAttackState(_monster));
        }
    }

    public void Exit()
    {

    }
}
