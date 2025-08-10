using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private SkillManager _skillManager;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private LayerMask _groundLayer;
    [SerializeField] private Rigidbody2D _rb;

    // 이동 관련
    private float _moveSpeed = 8f;
    private float _dashForce = 15f;
    private float _dashCooldown = 1f;
    private WaitForSeconds _dashDuration = new WaitForSeconds(0.2f);

    private float _gravityScale = 2f;
    private float _lastDashTime = -999f;
    private bool _isDashing = false;

    // 점프 관련
    private float _jumpForce = 10f;
    private float _fallMultiplier = 2.5f;
    private int _maxJumpCount = 2;
    private int _currentJumpCount = 0;

    private bool _isGrounded = false;
    private bool _wasGrounded = false;

    private IInteractableStone _currentStone;
    private IInteractablePortal _currentPortal;

    private void Awake()
    {
        _rb.gravityScale = _gravityScale;
    }

    private void Update()
    {
        InputKey();
    }

    private void FixedUpdate()
    {
        BetterJump();
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
            if (!_isDashing)
            {
                Move();
                Jump();
            }
            TryDash();
        }
    }

    private void Move()
    {
        float h = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))    h = -1;
        if (Input.GetKey(KeyCode.RightArrow))   h = 1;

        _rb.velocity = new Vector2(h * _moveSpeed, _rb.velocity.y);
    }

    private void Jump()
    {
        _isGrounded = Physics2D.OverlapCircle(_groundCheck.position, 0.1f, _groundLayer);

        if (_isGrounded && !_wasGrounded)
            _currentJumpCount = 0;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(_currentJumpCount < _maxJumpCount)
            {
                _rb.velocity = new Vector2(_rb.velocity.x, 0f);
                _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
                _currentJumpCount++;
            }
        }

        _wasGrounded = _isGrounded;
    }

    private void BetterJump()
    {
        if(_rb.velocity.y < 0)
        {
            _rb.velocity += Vector2.up * Physics2D.gravity.y * (_fallMultiplier - 1) * Time.fixedDeltaTime;
        }
    }

    private void TryDash()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            float dashDir = 0f;
            if (Input.GetKey(KeyCode.LeftArrow)) dashDir = -1f;
            else if (Input.GetKey(KeyCode.RightArrow)) dashDir = 1f;

            if (dashDir == 0f)
                return;

            if (Time.time >= _lastDashTime + _dashCooldown)
            {
                StartCoroutine(IEDashRoutine(dashDir));
                _lastDashTime = Time.time;
            }
        }
    }

    private IEnumerator IEDashRoutine(float dashDir)
    {
        _isDashing = true;

        if (!_isGrounded)
            _rb.gravityScale = 0f;

        _rb.velocity = new Vector2(dashDir * _dashForce, 0);

        yield return _dashDuration;

        if(!_isGrounded)
            _rb.gravityScale = _gravityScale;

        _isDashing = false;
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

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_groundCheck.position, 0.1f);
    }
}
