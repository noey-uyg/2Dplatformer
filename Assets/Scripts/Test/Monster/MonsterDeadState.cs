using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDeadState : IMonsterState
{
    private MonsterBase _monster;

    public MonsterDeadState(MonsterBase owner) { _monster = owner; }

    public void Enter()
    {
        //_monster.OnDead();
    }

    public void Exit() { }
    public void Update() { }
}
