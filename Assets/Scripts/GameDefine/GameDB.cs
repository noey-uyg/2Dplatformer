using UnityEngine;

[System.Serializable]
public struct SynergyTagData
{
    public int tag; // (Enum) SynergyTag
    public string name;
    public int stage;
    public string desc;
    public int effectType1; // (Enum) EffectType
    public int effectType2; // (Enum) EffectType
    public float effectValue1;
    public float effectValue2;
    public int effectValueNote1; // (Enum) ValueNote)
    public int effectValueNote2; // (Enum) ValueNote)
    public string colorCode;
    public string nameKey;
    public string descKey;
}