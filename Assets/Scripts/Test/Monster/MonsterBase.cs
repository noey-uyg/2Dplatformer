using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonsterBase : MonoBehaviour
{
    protected int _monsterID;
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

    public int MonsterID { get { return _monsterID; } }
    public MonsterType MonType { get { return _monsterType; } }
    public DamageType DamType { get { return _attackType; } }
    public MonsterMoveType MoveType { get { return _moveType; } }
    public bool IsBodyHitDam { get {  return _isBodyHitDam; } }
    public float BaseHP { get { return _baseHP; } }
    public float BaseAtk { get { return _baseAtk; } }
    public float BaseAtkCoolTime {  get { return _baseAtkCoolTime; } }
    public MonsterStateMachine StateMachine { get {  return _stateMachine; } }

    protected virtual void Awake()
    {
        _stateMachine = new MonsterStateMachine(this);
    }

    protected virtual void Update()
    {
        StateMachine.Update();
    }

    public abstract void Initialize(MonsterInfo data);
    public abstract void PerFormAttack();

    public virtual bool CheckPlayerInRange()
    {
        // 거리 계산
        return Vector2.Distance(transform.position, Vector2.zero) < 3f;
    }

    public virtual void TakeDamage(float damage)
    {
        _baseHP -= damage;
        if (_baseHP < 0)
            StateMachine.ChangeState(new MonsterDeadState(this));
    }

    public virtual void OnDead()
    {
        //MonsterPool.Instance.ReleaseMonster(this);
    }
}
