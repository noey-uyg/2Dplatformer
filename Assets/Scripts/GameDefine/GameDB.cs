using UnityEngine;

public struct SynergyTagData
{
    public int tag;                 // (Enum) SynergyTag
    public string name;
    public int stage;
    public string desc;
    public int effectType1;         // (Enum) EffectType
    public int effectType2;         // (Enum) EffectType
    public float effectValue1;
    public float effectValue2;
    public int effectValueNote1;    // (Enum) ValueNote
    public int effectValueNote2;    // (Enum) ValueNote
    public string colorCode;
    public string nameKey;
    public string descKey;
}

public struct ItemInfo
{
    public int id;
    public string name;
    public int synergyTag1; // (Enum) SynergyTag
    public int synergyTag2; // (Enum) SynergyTag
    public int effectType1; // (Enum) EffectType
    public int effectType2; // (Enum) EffectType
    public float effectValue1;
    public float effectValue2;
    public int effectValueNote1;
    public int effectValueNote2;
    public int triggerType; // (Enum)TiggerTarget
    public float triggerValue;
    public int triggerDuration;
    public string desc;
    public int grade;       // (Enum) TO DO
    public float weight;
    public string nameKey;
    public string descKey;
}

public struct GrowthUpgrade
{
    public int id;
    public string name;
    public string desc;
    public string iconPath;
    public int maxLevel;
    public float baseValue;
    public float valuePerLevel;
    public int baseCost;
    public float costGrowth;
    public int valueNote;   // (Enum) ValueNote
    public int statTarget;  // (Enum) EffectType;
    public string nameKey;
    public string descKey;
}

public struct JopInfo
{
    public int id;              // (Enum) JopType
    public string name;
    public string desc;
    public float defaultHP;
    public float defaultATK;
    public string note;
    public string nameKey;
    public string descKey;
}

public struct JopSkill
{
    public int id;              // (Enum) JopType
    public int slot;
    public int upgradeStage;    // (Enum) JopUpgrade
    public string name;
    public string desc;
    public int rangeType;       // (Enum) RangeType
    public int damageType;      // (Enum) DamageType
    public float cooldown;
    public string note;
    public string nameKey;
    public string descKey;
}

public struct JopUpgradeInfo
{
    public int id;                  // (Enum) JopType
    public int upgradeStage;
    public string effectDesc1;
    public string effectDesc2;
    public string effectDesc1Key;
    public string effectDesc2Key;
}

public struct MonsterInfo
{
    public int id;
    public string name;
    public int monsterType;
    public int baseAtkType;
    public int moveType;
    public int bodyHitDam;
    public float baseHp;
    public float baseAtk;
    public float atkCD;
    public string nameKey;
    public string note;
}

public struct MonsterPattern
{
    public int id;
    public int patternNo;
    public float cooldown;
    public int rangeType;
    public int effectType;
    public float effectValue;
    public float duration;
    public int condition;
    public float conditionValue;
    public int phase;
    public string note;
}

public struct MonsterPhase
{
    public int id;
    public int phase;
    public float changeHP;
    public string note;
}