using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : IMonsterMovement
{
    private MonsterBase _monster;
    public GroundMovement(MonsterBase monster) => _monster = monster;
    
    public void Move()
    {
        // �̵� AI ����
    }
}
