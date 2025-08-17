using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStateMachine
{
    private MonsterBase _monster;
    private IMonsterState _currentState;

    public MonsterStateMachine(MonsterBase owner)
    {
        _monster = owner;
        ChangeState(new MonsterIdleState(_monster));
    }

    public void Update()
    {
        _currentState?.Update();
    }

    public void ChangeState(IMonsterState newState)
    {
        _currentState?.Exit();
        _currentState = newState;
        _currentState?.Enter();
    }
}

