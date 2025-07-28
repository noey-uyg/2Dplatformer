using UnityEngine;

public static class GameDefine
{
    public enum SynergyTag
    {
        BRU=101,    // �Ͱ�
        END=102,    // �γ�
        AGI=103,    // ���
        PRE=104,    // ����
        SOL=105,    // ��ȥ
        WEA=106,    // �繰
    }

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

    public enum ValueNote
    {
        None = 0,
        Sum=1, // �տ��� base + N
        Mul=2, // ������ base + (base * N)
    }

    public enum TriggerTarget
    {
        None = 0,
        UltUse = 101,   // �ñر� ��� ��
        HitMe=102,      // �ǰ� ��
        CurHP=103       // ���� ü�� ������ ��
    }
}
