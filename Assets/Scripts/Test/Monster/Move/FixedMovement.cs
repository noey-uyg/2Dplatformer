using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedMovement : IMonsterMovement
{
    private MonsterBase _monster;

    public FixedMovement(MonsterBase monster) => _monster = monster;

    public void Move()
    {
        // 움직임 없음
    }
}
