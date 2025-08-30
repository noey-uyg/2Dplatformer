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
        //�̵�

        //�÷��̾� �����Ÿ� �̳� ���� �� ����
        if (_monster.CheckPlayerInRange())
        {
            Debug.Log("�����Ÿ� �̳�");
            _monster.StateMachine.ChangeState(new MonsterAttackState(_monster));
        }
    }

    public void Exit()
    {

    }
}
