using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMovement : IMonsterMovement
{
    private MonsterBase _monster;
    public FlyMovement(MonsterBase monster) => _monster = monster;

    public void Move()
    {
        // ���߿��� �÷��̾� �����ϴ� AI
    }
}
