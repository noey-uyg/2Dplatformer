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
    /// ��ȭ�Ǵ� ȿ�� Ÿ��
    /// </summary>
    public enum EffectType
    {
        None,
        Atk = 101,          // ���ݷ�
        MaxHP,              // �ִ� ü��
        MoveSpeed,          // �̵��ӵ�
        CoolDown,           // ��ų ��ü ��Ÿ��
        DamReduce,          // ���� ����
        Evasion,            // ȸ����
        CriRate,            // ġ��Ÿ Ȯ��
        CriDam,             // ġ��Ÿ ������
        DashCD,             // ��� ��Ÿ��
        RareUpgradeChance,  // ��� ��ȭ ȹ���
        SkillDam,           // ��ų ������
        UltCD = 301,        // �ñر� ��Ÿ��
        UltDam = 302,       // �ñر� ������
        UltUse = 303,       // �ñر� ��� ��
        GoldGain = 401,     // ��� ȹ�淮
        Sh��pDisc = 402,    // ���� ������
        SoulGain = 403,     // �ҿ� ȹ�淮
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
    /// ��ų ��� �� �ߵ� Ÿ��
    /// </summary>
    public enum TriggerTarget
    {
        None,
        UltUse = 101,   // �ñر� ��� ��
        HitMe=102,      // �ǰ� ��
        CurHP=103       // ���� ü�� ������ ��
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
        Base,
        Rare,
        Epic,
        Unique,
        Legend,
    }

    /// <summary>
    /// ���� Ÿ��
    /// </summary>
    public enum RangeType
    {
        None,
        Melee,  // ����
        Aoe,    // ����
        Range,  // ���Ÿ�
        Self,   // �ڱ� �ڽ� ���
    }


    /// <summary>
    /// ������ Ÿ��
    /// </summary>
    public enum DamageType
    {
        None,
        Physical,   // ����
        Magic,      // ����
        Utility,    // ����
    }
}
