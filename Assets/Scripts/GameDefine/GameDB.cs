using System.Diagnostics.Tracing;
using UnityEngine;

public struct SynergyTagData
{
    public int tag;                 // (Enum) SynergyTag, 시너지 기본 번호
    public string name;             // 시너지 이름
    public int stage;               // 시너지 활성화 개수
    public string desc;             // 설명
    public int effectType1;         // (Enum) EffectType 효과1
    public int effectType2;         // (Enum) EffectType 효과2
    public float effectValue1;      // 효과 값
    public float effectValue2;      // 효과 값
    public int effectValueNote1;    // (Enum) ValueNote 연산
    public int effectValueNote2;    // (Enum) ValueNote 연산
    public string colorCode;        // 컬러코드
    public string nameKey;          // 로컬라이징 키
    public string descKey;          // 로컬라이징 키
}

public struct ItemInfo
{
    public int id;                  // 아이템 기본 번호
    public string name;             // 아이템 이름
    public int synergyTag1;         // (Enum) SynergyTag 시너지 번호 1
    public int synergyTag2;         // (Enum) SynergyTag 시너지 번호 2
    public int effectType1;         // (Enum) EffectType 효과1
    public int effectType2;         // (Enum) EffectType 효과2
    public float effectValue1;      // 효과 값
    public float effectValue2;      // 효과 값
    public int effectValueNote1;    // 연산
    public int effectValueNote2;    // 연산
    public int triggerType;         // (Enum)TiggerTarget 발동 조건
    public float triggerValue;      // 발동 조건 값
    public int triggerDuration;     // 발동 후 지속시간
    public string desc;             // 아이템 설명
    public int grade;               // (Enum) TO DO 등급
    public float weight;            // 등장 가중치
    public string nameKey;          // 로컬라이징 키
    public string descKey;          // 로컬라이징 키
}

public struct GrowthUpgrade
{
    public int id;                  // 성장 특성 번호
    public string name;             // 이름
    public string desc;             // 설명
    public string iconPath;         // 아이콘 주소
    public int maxLevel;            // 최대 레벨
    public float baseValue;         // 기본 값
    public float valuePerLevel;     // 레벨 상승마다 오르는 비율
    public int baseCost;            // 기본 비용
    public float costGrowth;        // 레벨 상승마다 오르는 비용
    public int valueNote;           // (Enum) ValueNote 연산
    public int statTarget;          // (Enum) EffectType 효과
    public string nameKey;          // 로컬라이징 키
    public string descKey;          // 로컬라이징 키
}

public struct JopInfo
{
    public int id;              // (Enum) JopType 직업 번호
    public string name;         // 이름
    public string desc;         // 설명
    public float defaultHP;     // 기본 체력
    public float defaultATK;    // 기본 공격력
    public string note;         
    public string nameKey;      // 로컬라이징 키
    public string descKey;      // 로컬라이징 키
}

public struct JopSkill
{
    public int id;              // (Enum) JopType 직업 번호
    public int slot;            // 스킬 슬롯
    public int upgradeStage;    // (Enum) JopUpgrade 전직 단계
    public string name;         // 이름
    public string desc;         // 설명
    public int rangeType;       // (Enum) RangeType 범위 타입
    public int damageType;      // (Enum) DamageType 데미지 타입
    public float cooldown;      // 스킬 쿨타임
    public string note;
    public string nameKey;      // 로컬라이징 키
    public string descKey;      // 로컬라이징 키
}

public struct JopUpgradeInfo
{
    public int id;                  // (Enum) JopType 직업 번호
    public int upgradeStage;        // 전직 단계
    public string effectDesc1;      // 스킬1 설명
    public string effectDesc2;      // 스킬2 설명
    public string effectDesc1Key;   // 로컬라이징 키
    public string effectDesc2Key;   // 로컬라이징 키
}

public struct MonsterInfo
{
    public int id;              // 몬스터 아이디
    public string name;         // 몬스터 이름
    public int monsterType;     // (Enum) MonsterType 몬스터 타입(기본, 엘리트, 보스)
    public int baseAtkType;     // 기본 공격 타입
    public int moveType;        // (Enum) MonsterMoveType 몬스터 움직임 타입(지상, 공중, 고정)
    public bool bodyHitDam;     // 몸박 데미지 유무
    public float baseHp;        // 기본 체력
    public float baseAtk;       // 기본 공격력
    public float atkCD;         // 기본 공격 쿨타임
    public string nameKey;      // 로컬라이징 키
    public string note;
}

public struct MonsterPattern
{
    public int id;                  // 몬스터 아이디
    public int patternNo;           // 패턴 번호
    public float cooldown;          // 패턴 쿨타임
    public int rangeType;           // (Enum) RangeType 범위 타입
    public int effectType;          // 효과
    public float effectValue;       // 효과 값
    public float duration;          // 지속 시간
    public int condition;           // 발동 조건
    public float conditionValue;    // 조건 값
    public int phase;               // 어느 페이즈에서 발동 되는것인지
    public string note;
}

public struct MonsterPhase
{
    public int id;          // 몬스터 번호
    public int phase;       // 페이즈
    public float changeHP;  // 변경 HP
    public string note;
}

public struct MapInfo
{
    public int mapID;               // 맵 번호
    public int stageID;             // 스테이지
    public int mapType;             // 맵 타입
    public string mapPrefabName;    // 프리팹 이름
    public bool isHidden;           // 히든맵인지
    public string prefabPath;       // 프리팹 주소
}

public struct MonsterSpawn
{
    public int mapID;       // 맵 번호
    public int spawnID;     // 맵 스폰 위치 인덱스
    public int monsterID;   // 몬스터 아이디
    public int level;       // 몬스터 레벨
}

public struct SoulInfo
{
    public int id;
    public string name;
    public string desc;
    public string nameKey;
    public string descKey;
}

public struct SoulSkill
{
    public int id;
    public string name;
    public string desc;
    public float cooldown;
    public string nameKey;
    public string descKey;
}

public struct SoulUpgrade
{
    public int id;
    public int upgradeID;
    public string desc;
    public string descKey;
}