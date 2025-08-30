using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : IMonsterMovement
{
    private MonsterBase _monster;
    private bool _movingRight = false;
    public GroundMovement(MonsterBase monster)
    {
        _monster = monster;
        _movingRight = Random.value > 0.5f;

        if (_movingRight)
            _monster.Flip();
    }
    

    public void Move()
    {
        Vector3 moveDir = _movingRight ? Vector3.right : Vector3.left;

        Vector2 origin = _monster.FrontCheck.position;
        RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.down, 0.75f, LayerMask.GetMask("Ground"));
        Debug.DrawRay(origin, Vector2.down * 0.75f, Color.red);
        if (hit.collider == null)
        {
            _movingRight = !_movingRight;
            _monster.Flip();
            return;
        }

        _monster.MonsterMove(moveDir);
    }
}
