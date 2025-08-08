using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private SkillManager _skillManager;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private LayerMask _groundLayer;
    [SerializeField] private Rigidbody2D _rb;

    private float _moveSpeed = 5f;
    private float _jumpForce = 5f;
    private bool _isGrounded = false;

    private IInteractableStone _currentStone;
    private IInteractablePortal _currentPortal;

    private void Update()
    {
        InputKey();
    }

    private void InputKey()
    {
        { // 스킬
            if (Input.GetKeyDown(KeyCode.A))
            {
                _skillManager.UseSkill(1);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                _skillManager.UseSkill(2);
            }
        }

        { // 상호작용
            if (Input.GetKeyDown(KeyCode.F) && _currentStone != null)
            {
                _currentStone.OnSelect();
            }
            if (Input.GetKeyDown(KeyCode.R) && _currentStone != null)
            {
                _currentStone.OnReroll();
            }
            if(Input.GetKeyDown(KeyCode.UpArrow) && _currentPortal != null)
            {
                _currentPortal.OnEnterPortal();
            }
        }

        { // 움직임
            Move();

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Jump();
            }
        }
    }

    private void Move()
    {
        float h = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            h = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            h = 1;
        }

        _rb.velocity = new Vector2(h * _moveSpeed, _rb.velocity.y);
    }

    private void Jump()
    {
        _isGrounded = Physics2D.OverlapCircle(_groundCheck.position, 0.1f, _groundLayer);

        if (_isGrounded)
        {
            _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out IInteractableStone stone))
            _currentStone = stone;

        if(collision.TryGetComponent(out IInteractablePortal portal))
            _currentPortal = portal;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out IInteractableStone stone) && _currentStone == stone)
            _currentStone = null;

        if(collision.TryGetComponent(out IInteractablePortal portal) && _currentPortal == portal)
            _currentPortal = null;
    }
}
