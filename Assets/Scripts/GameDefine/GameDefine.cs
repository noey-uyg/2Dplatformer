using UnityEngine;

public static class GameDefine
{
    public enum SynergyTag
    {
        BRU=101,    // 맹공
        END=102,    // 인내
        AGI=103,    // 기민
        PRE=104,    // 정밀
        SOL=105,    // 영혼
        WEA=106,    // 재물
    }

    public enum EffectType
    {
        None,
        Atk = 101,          // 공격력
        MaxHP,              // 최대 체력
        MoveSpeed,          // 이동속도
        CoolDown,           // 스킬 전체 쿨타임
        DamReduce,          // 피해 감소
        Evasion,            // 회피율
        CriRate,            // 치명타 확률
        CriDam,             // 치명타 데미지
        DashCD,             // 대시 쿨타임
        RareUpgradeChance,  // 희귀 강화 획득률
        SkillDam,           // 스킬 데미지
        UltCD = 301,        // 궁극기 쿨타임
        UltDam = 302,       // 궁극기 데미지
        UltUse = 303,       // 궁극기 사용 시
        GoldGain = 401,     // 골드 획득량
        ShㅐpDisc = 402,    // 상점 할인율
        SoulGain = 403,     // 소울 획득량
    }

    public enum ValueNote
    {
        None = 0,
        Sum=1, // 합연산 base + N
        Mul=2, // 곱연산 base + (base * N)
    }

    public enum TriggerTarget
    {
        None = 0,
        UltUse = 101,   // 궁극기 사용 시
        HitMe=102,      // 피격 시
        CurHP=103       // 일정 체력 이하일 시
    }
}
