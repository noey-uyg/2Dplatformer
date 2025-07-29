using System.Diagnostics.Tracing;
using UnityEngine;

public static class GameDefine
{
    /// <summary>
    /// �ó��� Ÿ��
    /// </summary>
    public enum SynergyTag
    {
        None,
        BRU=101,    // �Ͱ�
        END=102,    // �γ�
        AGI=103,    // ���
        PRE=104,    // ����
        SOL=105,    // ��ȥ
        WEA=106,    // �繰
    }

    /// <summary>
    /// ȿ�� Ÿ��
    /// </summary>
    public enum EffectType
    {
        None,
        Atk = 101,                  // ���ݷ� ����
        MaxHP = 102,                // �ִ� ü�� ����
        MoveSpeed = 103,            // �̵��ӵ� ����
        CoolDown = 104,             // ��ų ��ü ��Ÿ�� ����
        DamReduce = 105,            // ���� ����
        Evasion = 106,              // ȸ���� ����
        CriRate = 107,              // ġ��Ÿ Ȯ�� ����
        CriDam = 108,               // ġ��Ÿ ������ ����
        DashCD = 109,               // ��� ��Ÿ�� ����
        RareUpgradeChance = 110,    // ��� ��ȭ ȹ��� ����
        SkillDam = 111,             // ��ų ������ ����
        Dotimm = 112,               // ��Ʈ ������ �鿪
        CurCD = 113,                // ���� ��Ÿ�� ����
        Heal = 113,                 // ü�� ȸ��
        UltCD = 301,                // �ñر� ��Ÿ�� ����
        UltDam = 302,               // �ñر� ������ ����
        UltUse = 303,               // �ñر� ��� ��
        GoldGain = 401,             // ��� ȹ�淮 ����
        Sh��pDisc = 402,            // ���� ������ ����
        SoulGain = 403,             // �ҿ� ȹ�淮 ����
        DotDamage = 1001,           // ��Ʈ ������
        StatusFreeze = 1002,        // ���� �����̻�
        StatusBleed = 1003,         // ���� �����̻�
        Summon = 1004,              // ��ȯ
    }

    /// <summary>
    /// ���� Ÿ��
    /// </summary>
    public enum ValueNote
    {
        None,
        Sum=1, // �տ��� base + N
        Mul=2, // ������ base + (base * N)
    }

    /// <summary>
    /// �ߵ� ����
    /// </summary>
    public enum TriggerTarget
    {
        None,
        UltUse = 101,   // �ñر� ��� ��
        HitMe=102,      // �ǰ� ��
        CurHP=103,      // ���� ü�� ������ ��
        Hit=104,        // �Ϲ� ���� ��
        interval=105,   // ���� �ð� ����
        Die=106,        // ��� ��
    }

    /// <summary>
    /// ���� ����
    /// </summary>
    public enum JopType
    {
        None,
        War = 101,  // ����
        Mag = 201,  // ������
        Rog = 301,  // ����
        Arc = 401,  // �ü�
    }

    /// <summary>
    /// ���� �ܰ�
    /// </summary>
    public enum JopUpgrade
    {
        None,
        Base=1,
        Rare=2,
        Epic=3,
        Unique=4,
        Legend=5,
    }

    /// <summary>
    /// ���� Ÿ��(�÷��̾� And ������ �⺻ ���� Ÿ��)
    /// </summary>
    public enum RangeType
    {
        None,
        Melee=1,  // ����
        Aoe=2,    // ����
        Range=3,  // ���Ÿ�
        Self=4,   // �ڱ� �ڽ� ���
        All=5,    // �� ����
    }

    /// <summary>
    /// ������ Ÿ��
    /// </summary>
    public enum DamageType
    {
        None,
        Physical=1,   // ����
        Magic=2,      // ����
        Utility=3,    // ����
    }

    /// <summary>
    /// ���� Ÿ��
    /// </summary>
    public enum MonsterType
    {
        None,
        Normal=1, // �Ϲ�
        Elite=2,  // ����Ʈ
        Boss=3,   // ����
    }

    /// <summary>
    /// ���� ��ġ Ÿ��
    /// </summary>
    public enum MonsterMoveType
    {
        None,
        Ground=1, // ����
        Fly=2,    // ����
        Fix=3,    // ����
    }

    public enum PatternType
    {
        None,
        Passive = 1,    // �нú�
        Active = 2,     // ��Ƽ��
    }

    /// <summary>
    /// �� Ÿ��
    /// </summary>
    public enum MapType
    {
        None,
        Normal = 1, // �Ϲ� ��
        Hidden = 2, // ���� ��
        Boss = 3,   // ���� ��
    }
}
