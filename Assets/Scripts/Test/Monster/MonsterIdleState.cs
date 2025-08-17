using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterIdleState : IMonsterState
{
    private MonsterBase _monster;
    private float _idleTime;

    public MonsterIdleState(MonsterBase onwer) { _monster = onwer; }

    public void Enter()
    {
        _idleTime = UnityEngine.Random.Range(1f, 3f);
    }

    public void Update()
    {
        _idleTime -= Time.deltaTime;
        //if (_idleTime < 0f)
            //_monster.StateMachine.ChangeState(new MonsterMoveState(_monster));

    }

    public void Exit() { }
}