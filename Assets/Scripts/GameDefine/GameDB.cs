using System.Diagnostics.Tracing;
using UnityEngine;

public struct SynergyTagData
{
    public int tag;                 // (Enum) SynergyTag, �ó��� �⺻ ��ȣ
    public string name;             // �ó��� �̸�
    public int stage;               // �ó��� Ȱ��ȭ ����
    public string desc;             // ����
    public int effectType1;         // (Enum) EffectType ȿ��1
    public int effectType2;         // (Enum) EffectType ȿ��2
    public float effectValue1;      // ȿ�� ��
    public float effectValue2;      // ȿ�� ��
    public int effectValueNote1;    // (Enum) ValueNote ����
    public int effectValueNote2;    // (Enum) ValueNote ����
    public string colorCode;        // �÷��ڵ�
    public string nameKey;          // ���ö���¡ Ű
    public string descKey;          // ���ö���¡ Ű
}

public struct ItemInfo
{
    public int id;                  // ������ �⺻ ��ȣ
    public string name;             // ������ �̸�
    public int synergyTag1;         // (Enum) SynergyTag �ó��� ��ȣ 1
    public int synergyTag2;         // (Enum) SynergyTag �ó��� ��ȣ 2
    public int effectType1;         // (Enum) EffectType ȿ��1
    public int effectType2;         // (Enum) EffectType ȿ��2
    public float effectValue1;      // ȿ�� ��
    public float effectValue2;      // ȿ�� ��
    public int effectValueNote1;    // ����
    public int effectValueNote2;    // ����
    public int triggerType;         // (Enum)TiggerTarget �ߵ� ����
    public float triggerValue;      // �ߵ� ���� ��
    public int triggerDuration;     // �ߵ� �� ���ӽð�
    public string desc;             // ������ ����
    public int grade;               // (Enum) TO DO ���
    public float weight;            // ���� ����ġ
    public string nameKey;          // ���ö���¡ Ű
    public string descKey;          // ���ö���¡ Ű
}

public struct GrowthUpgrade
{
    public int id;                  // ���� Ư�� ��ȣ
    public string name;             // �̸�
    public string desc;             // ����
    public string iconPath;         // ������ �ּ�
    public int maxLevel;            // �ִ� ����
    public float baseValue;         // �⺻ ��
    public float valuePerLevel;     // ���� ��¸��� ������ ����
    public int baseCost;            // �⺻ ���
    public float costGrowth;        // ���� ��¸��� ������ ���
    public int valueNote;           // (Enum) ValueNote ����
    public int statTarget;          // (Enum) EffectType ȿ��
    public string nameKey;          // ���ö���¡ Ű
    public string descKey;          // ���ö���¡ Ű
}

public struct JopInfo
{
    public int id;              // (Enum) JopType ���� ��ȣ
    public string name;         // �̸�
    public string desc;         // ����
    public float defaultHP;     // �⺻ ü��
    public float defaultATK;    // �⺻ ���ݷ�
    public string note;         
    public string nameKey;      // ���ö���¡ Ű
    public string descKey;      // ���ö���¡ Ű
}

public struct JopSkill
{
    public int id;              // (Enum) JopType ���� ��ȣ
    public int slot;            // ��ų ����
    public int upgradeStage;    // (Enum) JopUpgrade ���� �ܰ�
    public string name;         // �̸�
    public string desc;         // ����
    public int rangeType;       // (Enum) RangeType ���� Ÿ��
    public int damageType;      // (Enum) DamageType ������ Ÿ��
    public float cooldown;      // ��ų ��Ÿ��
    public string note;
    public string nameKey;      // ���ö���¡ Ű
    public string descKey;      // ���ö���¡ Ű
}

public struct JopUpgradeInfo
{
    public int id;                  // (Enum) JopType ���� ��ȣ
    public int upgradeStage;        // ���� �ܰ�
    public string effectDesc1;      // ��ų1 ����
    public string effectDesc2;      // ��ų2 ����
    public string effectDesc1Key;   // ���ö���¡ Ű
    public string effectDesc2Key;   // ���ö���¡ Ű
}

public struct MonsterInfo
{
    public int id;              // ���� ���̵�
    public string name;         // ���� �̸�
    public int monsterType;     // (Enum) MonsterType ���� Ÿ��(�⺻, ����Ʈ, ����)
    public int baseAtkType;     // �⺻ ���� Ÿ��
    public int moveType;        // (Enum) MonsterMoveType ���� ������ Ÿ��(����, ����, ����)
    public bool bodyHitDam;     // ���� ������ ����
    public float baseHp;        // �⺻ ü��
    public float baseAtk;       // �⺻ ���ݷ�
    public float atkCD;         // �⺻ ���� ��Ÿ��
    public string nameKey;      // ���ö���¡ Ű
    public string note;
}

public struct MonsterPattern
{
    public int id;                  // ���� ���̵�
    public int patternNo;           // ���� ��ȣ
    public float cooldown;          // ���� ��Ÿ��
    public int rangeType;           // (Enum) RangeType ���� Ÿ��
    public int effectType;          // ȿ��
    public float effectValue;       // ȿ�� ��
    public float duration;          // ���� �ð�
    public int condition;           // �ߵ� ����
    public float conditionValue;    // ���� ��
    public int phase;               // ��� ������� �ߵ� �Ǵ°�����
    public string note;
}

public struct MonsterPhase
{
    public int id;          // ���� ��ȣ
    public int phase;       // ������
    public float changeHP;  // ���� HP
    public string note;
}

public struct MapInfo
{
    public int mapID;               // �� ��ȣ
    public int stageID;             // ��������
    public int mapType;             // �� Ÿ��
    public string mapPrefabName;    // ������ �̸�
    public bool isHidden;           // ���������
    public string prefabPath;       // ������ �ּ�
}

public struct MonsterSpawn
{
    public int mapID;       // �� ��ȣ
    public int spawnID;     // �� ���� ��ġ �ε���
    public int monsterID;   // ���� ���̵�
    public int level;       // ���� ����
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