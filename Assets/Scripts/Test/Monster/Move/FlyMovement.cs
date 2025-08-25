using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMovement : IMonsterMovement
{
    private MonsterBase _monster;
    public FlyMovement(MonsterBase monster) => _monster = monster;

    public void Move()
    {
        // 공중에서 플레이어 추적하는 AI
    }
}
