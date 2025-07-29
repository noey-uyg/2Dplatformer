using System.Diagnostics.Tracing;
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
    /// 효과 타입
    /// </summary>
    public enum EffectType
    {
        None,
        Atk = 101,                  // 공격력 증감
        MaxHP = 102,                // 최대 체력 증감
        MoveSpeed = 103,            // 이동속도 증감
        CoolDown = 104,             // 스킬 전체 쿨타임 증감
        DamReduce = 105,            // 피해 증감
        Evasion = 106,              // 회피율 증감
        CriRate = 107,              // 치명타 확률 증감
        CriDam = 108,               // 치명타 데미지 증감
        DashCD = 109,               // 대시 쿨타임 증감
        RareUpgradeChance = 110,    // 희귀 강화 획득률 증감
        SkillDam = 111,             // 스킬 데미지 증감
        Dotimm = 112,               // 도트 데미지 면역
        CurCD = 113,                // 현재 쿨타임 증감
        Heal = 113,                 // 체력 회복
        UltCD = 301,                // 궁극기 쿨타임 증감
        UltDam = 302,               // 궁극기 데미지 증감
        UltUse = 303,               // 궁극기 사용 시
        GoldGain = 401,             // 골드 획득량 증감
        ShㅐpDisc = 402,            // 상점 할인율 증감
        SoulGain = 403,             // 소울 획득량 증감
        DotDamage = 1001,           // 도트 데미지
        StatusFreeze = 1002,        // 빙결 상태이상
        StatusBleed = 1003,         // 출혈 상태이상
        Summon = 1004,              // 소환
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
    /// 발동 조건
    /// </summary>
    public enum TriggerTarget
    {
        None,
        UltUse = 101,   // 궁극기 사용 시
        HitMe=102,      // 피격 시
        CurHP=103,      // 일정 체력 이하일 시
        Hit=104,        // 일반 공격 시
        interval=105,   // 일정 시간 마다
        Die=106,        // 사망 시
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
        Base=1,
        Rare=2,
        Epic=3,
        Unique=4,
        Legend=5,
    }

    /// <summary>
    /// 공격 타입(플레이어 And 몬스터의 기본 공격 타입)
    /// </summary>
    public enum RangeType
    {
        None,
        Melee=1,  // 근접
        Aoe=2,    // 범위
        Range=3,  // 원거리
        Self=4,   // 자기 자신 대상
        All=5,    // 맵 전역
    }

    /// <summary>
    /// 데미지 타입
    /// </summary>
    public enum DamageType
    {
        None,
        Physical=1,   // 물리
        Magic=2,      // 마법
        Utility=3,    // 보조
    }

    /// <summary>
    /// 몬스터 타입
    /// </summary>
    public enum MonsterType
    {
        None,
        Normal=1, // 일반
        Elite=2,  // 엘리트
        Boss=3,   // 보스
    }

    /// <summary>
    /// 몬스터 위치 타입
    /// </summary>
    public enum MonsterMoveType
    {
        None,
        Ground=1, // 지상
        Fly=2,    // 공중
        Fix=3,    // 고정
    }

    public enum PatternType
    {
        None,
        Passive = 1,    // 패시브
        Active = 2,     // 액티브
    }

    /// <summary>
    /// 맵 타입
    /// </summary>
    public enum MapType
    {
        None,
        Normal = 1, // 일반 맵
        Hidden = 2, // 히든 맵
        Boss = 3,   // 보스 맵
    }
}
