using UnityEngine;

[System.Serializable]
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

[System.Serializable]
public struct ItemCSV
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

[System.Serializable]
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