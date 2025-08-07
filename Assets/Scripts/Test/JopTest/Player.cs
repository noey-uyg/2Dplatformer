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

    private void Update()
    {
        InputKey();
    }

    private void InputKey()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            _skillManager.UseSkill(1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _skillManager.UseSkill(2);
        }
        if (Input.GetKeyDown(KeyCode.F) && _currentStone != null)
        {
            _currentStone.OnSelect();
        }
        if (Input.GetKeyDown(KeyCode.R) && _currentStone != null)
        {
            _currentStone.OnReroll();
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
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out IInteractableStone stone) && _currentStone == stone)
            _currentStone = null;
    }
}
