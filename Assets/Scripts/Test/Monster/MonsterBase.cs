using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonsterBase : MonoBehaviour
{
    [SerializeField] protected int _monsterID;
    [SerializeField] protected Transform _frontCheck;
    protected string _name;
    protected MonsterType _monsterType;
    protected DamageType _attackType;
    protected MonsterMoveType _moveType;
    protected bool _isBodyHitDam;
    protected float _baseHP;
    protected float _baseAtk;
    protected float _baseAtkCoolTime;
    protected float _moveSpeed = 3f;

    private MonsterStateMachine _stateMachine;
    private IMonsterMovement _movement;
    private float _detectionRange = 3f;
    private float _edgeCheckDistance = 0.1f;
    private Transform _transform;

    public event Action<MonsterBase> OnDeath;
    
    public int MonsterID { get { return _monsterID; } }
    public MonsterType MonType { get { return _monsterType; } }
    public DamageType DamType { get { return _attackType; } }
    public MonsterMoveType MoveType { get { return _moveType; } }
    public bool IsBodyHitDam { get {  return _isBodyHitDam; } }
    public float BaseHP { get { return _baseHP; } }
    public float BaseAtk { get { return _baseAtk; } }
    public float BaseAtkCoolTime {  get { return _baseAtkCoolTime; } }
    public MonsterStateMachine StateMachine { get {  return _stateMachine; } }
    public float DetectionRange { get { return _detectionRange; } }
    public float EdgeCheckDistance { get { return _edgeCheckDistance; } }
    public Transform FrontCheck {  get { return _frontCheck; } }
    public float MoveSpeed { get { return _moveSpeed; } }
    public Transform GetTransform {  get { return _transform; } }

    protected virtual void Awake()
    {
        _stateMachine = new MonsterStateMachine(this);
        _transform = GetComponent<Transform>();
    }

    protected virtual void Update()
    {
        _stateMachine?.Update();
        _movement?.Move();
    }

    public virtual void Initialize(MonsterInfo data)
    {
        switch (_moveType)
        {
            case MonsterMoveType.Ground:
                _movement = new GroundMovement(this);
                break;
            case MonsterMoveType.Fly:
                _movement = new FlyMovement(this);
                break;
            case MonsterMoveType.Fix:
                _movement = new FixedMovement(this);
                break;
        }
    }

    public abstract void PerformAttack();

    public virtual bool CheckPlayerInRange()
    {
        return Vector2.Distance(transform.position, Vector2.zero) < _detectionRange;
    }

    public virtual void TakeDamage(float damage)
    {
        _baseHP -= damage;
        if (_baseHP <= 0)
            StateMachine.ChangeState(new MonsterDeadState(this));
    }

    public virtual void OnDead()
    {
        OnDeath?.Invoke(this);
        MonsterPool.Instance.ReleaseMonster(this);
    }

    public void MonsterMove(Vector3 moveDir)
    {
        _transform.position += moveDir * _moveSpeed * Time.deltaTime;
    }

    public void Flip()
    {
        _transform.localScale *= -1;
    }
}
