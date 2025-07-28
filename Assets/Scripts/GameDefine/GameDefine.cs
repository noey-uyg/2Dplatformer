using UnityEngine;

public static class GameDefine
{
    /// <summary>
    /// 시너지 타입
    /// </summary>
    public enum SynergyTag
    {
        None,
        BRU=101,    // 맹공
        END=102,    // 인내
        AGI=103,    // 기민
        PRE=104,    // 정밀
        SOL=105,    // 영혼
        WEA=106,    // 재물
    }

    /// <summary>
    /// 강화되는 효과 타입
    /// </summary>
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

    /// <summary>
    /// 연산 타입
    /// </summary>
    public enum ValueNote
    {
        None,
        Sum=1, // 합연산 base + N
        Mul=2, // 곱연산 base + (base * N)
    }

    /// <summary>
    /// 스킬 사용 시 발동 타겟
    /// </summary>
    public enum TriggerTarget
    {
        None,
        UltUse = 101,   // 궁극기 사용 시
        HitMe=102,      // 피격 시
        CurHP=103       // 일정 체력 이하일 시
    }

    /// <summary>
    /// 직업 종류
    /// </summary>
    public enum JopType
    {
        None,
        War = 101,  // 전사
        Mag = 201,  // 마법사
        Rog = 301,  // 도적
        Arc = 401,  // 궁수
    }

    /// <summary>
    /// 전직 단계
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
    /// 공격 타입
    /// </summary>
    public enum RangeType
    {
        None,
        Melee,  // 근접
        Aoe,    // 범위
        Range,  // 원거리
        Self,   // 자기 자신 대상
    }


    /// <summary>
    /// 데미지 타입
    /// </summary>
    public enum DamageType
    {
        None,
        Physical,   // 물리
        Magic,      // 마법
        Utility,    // 보조
    }
}
