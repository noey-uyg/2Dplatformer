using System.Collections.Generic;
using UnityEngine;

public class CSVLoader : MonoBehaviour
{
    private const string SynergyTagPath = "CSV/synergy_tags";
    private const string ItemInfoPath = "CSV/item_list";
    private const string GrowthUpgradePath = "CSV/growth_upgrade";
    private const string JopInfoPath = "CSV/jop_list";
    private const string JopSkillPath = "CSV/jop_skills";
    private const string JopUpgradePath = "CSV/jop_upgrade";
    private const string MonsterListPath = "CSV/monster_list";
    private const string MonsterPatternPath = "CSV/monster_pattern";
    private const string MonsterPhasePath = "CSV/monster_phase";

    public static Dictionary<int, SynergyTagData> SynergyTagDict = new();
    public static Dictionary<int, ItemInfo> ItemInfoDict = new();
    public static Dictionary<int, GrowthUpgrade> GrowthUpgradeDict = new();
    public static Dictionary<int, JopInfo> JopInfoDict = new();
    public static Dictionary<int, JopSkill> JopSkillDict = new();
    public static Dictionary<int, JopUpgradeInfo> JopUpgradeInfoDict = new();
    public static Dictionary<int, MonsterInfo> MonsterInfoDict = new();
    public static Dictionary<int, MonsterPattern> MonsterPatternDict = new();
    public static Dictionary<int, MonsterPhase> MonsterPhaseDict = new();

    private void Awake()
    {
        AllCSVLoad();
    }

    public static void AllCSVLoad()
    {
        LoadSynergyTag();
        LoadItem();
        LoadGrowthUpgrade();
        LoadJopInfo();
        LoadJopSkill();
        LoadJopUpgrade();
        LoadMonsterInfo();
        LoadMonsterPattern();
        LoadMonsterPhase();
    }

    public static string LoadCSV(string path)
    {
        TextAsset asset = Resources.Load<TextAsset>(path);
        if(asset == null)
        {
            Debug.LogError($"CSV 파일을 찾을 수 없습니다. {path}");
            return string.Empty;
        }
        return asset.text;
    }

    #region SynergyTag
    public static void LoadSynergyTag()
    {
        var csv = LoadCSV(SynergyTagPath);

        if (string.IsNullOrEmpty(csv))
            return;

        SynergyTagDict.Clear();

        string[] lines = csv.Split('\n');

        for(int i = 1; i < lines.Length; i++)
        {
            string line = lines[i].Trim();
            
            if(string.IsNullOrEmpty(line) ) continue;

            string[] values = line.Split(",");

            SynergyTagData data = new SynergyTagData();

            data.tag = int.Parse(values[0]);
            data.name = values[1];
            data.stage = int.Parse(values[2]);
            data.desc = values[3];
            data.effectType1 = int.Parse(values[4]);
            data.effectType2 = int.Parse(values[5]);
            data.effectValue1 = float.Parse(values[6]);
            data.effectValue2 = float.Parse(values[7]);
            data.effectValueNote1 = int.Parse(values[8]);
            data.effectValueNote2 = int.Parse(values[9]);
            data.colorCode = values[10];
            data.nameKey = values[11];
            data.descKey = values[12];

            int key = data.tag * 100 + i;

            if(!SynergyTagDict.ContainsKey(key))
            {
                SynergyTagDict.Add(key, data);
            }
            else
            {
                Debug.LogWarning($"SynergyTag중복된 키 : {key} (줄 {i + 1})");
            }
        }
    }
    #endregion

    #region ItemList
    public static void LoadItem()
    {
        var csv = LoadCSV(ItemInfoPath);

        if (string.IsNullOrEmpty(csv))
            return;

        ItemInfoDict.Clear();

        string[] lines = csv.Split('\n');

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i].Trim();

            if (string.IsNullOrEmpty(line)) continue;

            string[] values = line.Split(",");

            ItemInfo data = new ItemInfo();

            data.id = int.Parse(values[0]);
            data.name = values[1];
            data.synergyTag1 = int.Parse(values[2]);
            data.synergyTag2 = int.Parse(values[3]);
            data.effectType1 = int.Parse(values[4]);
            data.effectType2 = int.Parse(values[5]);
            data.effectValue1 = float.Parse(values[6]);
            data.effectValue2 = float.Parse(values[7]);
            data.effectValueNote1 = int.Parse(values[8]);
            data.effectValueNote2 = int.Parse(values[9]);
            data.triggerType = int.Parse(values[10]);
            data.triggerValue = float.Parse(values[11]);
            data.triggerDuration = int.Parse(values[12]);
            data.desc = values[13];
            data.grade = int.Parse(values[14]);
            data.weight = float.Parse(values[15]);
            data.nameKey = values[16];
            data.descKey = values[17];

            int key = data.id;

            if (!ItemInfoDict.ContainsKey(key))
            {
                ItemInfoDict.Add(key, data);
            }
            else
            {
                Debug.LogWarning($"LoadItem 중복된 키 : {key} (줄 {i + 1})");
            }
        }
    }
    #endregion

    #region GrowthUpgrade
    public static void LoadGrowthUpgrade()
    {
        var csv = LoadCSV(GrowthUpgradePath);

        if (string.IsNullOrEmpty(csv))
            return;

        GrowthUpgradeDict.Clear();

        string[] lines = csv.Split('\n');

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i].Trim();

            if (string.IsNullOrEmpty(line)) continue;

            string[] values = line.Split(",");

            GrowthUpgrade data = new GrowthUpgrade();

            data.id = int.Parse(values[0]);
            data.name = values[1];
            data.desc = values[2];
            data.iconPath = values[3];
            data.maxLevel = int.Parse(values[4]);
            data.baseValue = float.Parse(values[5]);
            data.valuePerLevel = float.Parse(values[6]);
            data.baseCost = int.Parse(values[7]);
            data.costGrowth = float.Parse(values[8]);
            data.valueNote = int.Parse(values[9]);
            data.statTarget = int.Parse(values[10]);
            data.nameKey = values[11];
            data.descKey = values[12];

            int key = data.id;

            if (!GrowthUpgradeDict.ContainsKey(key))
            {
                GrowthUpgradeDict.Add(key, data);
            }
            else
            {
                Debug.LogWarning($"GrowthUpgrade 중복된 키 : {key} (줄 {i + 1})");
            }
        }
    }
    #endregion

    #region JopInfo
    public static void LoadJopInfo()
    {
        var csv = LoadCSV(JopInfoPath);

        if (string.IsNullOrEmpty(csv))
            return;

        JopInfoDict.Clear();

        string[] lines = csv.Split('\n');

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i].Trim();

            if (string.IsNullOrEmpty(line)) continue;

            string[] values = line.Split(",");

            JopInfo data = new JopInfo();

            data.id = int.Parse(values[0]);
            data.name = values[1];
            data.desc = values[2];
            data.defaultHP = float.Parse(values[3]);
            data.defaultATK = float.Parse(values[4]);
            data.nameKey = values[5];
            data.descKey = values[6];

            int key = data.id;

            if (!JopInfoDict.ContainsKey(key))
            {
                JopInfoDict.Add(key, data);
            }
            else
            {
                Debug.LogWarning($"JopInfoDict 중복된 키 : {key} (줄 {i + 1})");
            }
        }
    }
    #endregion

    #region JopSkill
    public static void LoadJopSkill()
    {
        var csv = LoadCSV(JopSkillPath);

        if (string.IsNullOrEmpty(csv))
            return;

        JopSkillDict.Clear();

        string[] lines = csv.Split('\n');

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i].Trim();

            if (string.IsNullOrEmpty(line)) continue;

            string[] values = line.Split(",");

            JopSkill data = new JopSkill();

            data.id = int.Parse(values[0]);
            data.slot = int.Parse(values[1]);
            data.upgradeStage = int.Parse(values[2]);
            data.name = values[3];
            data.desc = values[4];
            data.rangeType = int.Parse(values[5]);
            data.damageType = int.Parse(values[6]);
            data.cooldown = float.Parse(values[7]);
            data.nameKey = values[8];
            data.descKey = values[9];

            int key = data.id * 100 + data.slot;

            if (!JopSkillDict.ContainsKey(key))
            {
                JopSkillDict.Add(key, data);
            }
            else
            {
                Debug.LogWarning($"JopInfoDict 중복된 키 : {key} (줄 {i + 1})");
            }
        }
    }
    #endregion

    #region JopUpgrade
    public static void LoadJopUpgrade()
    {
        var csv = LoadCSV(JopUpgradePath);

        if (string.IsNullOrEmpty(csv))
            return;

        JopUpgradeInfoDict.Clear();

        string[] lines = csv.Split('\n');

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i].Trim();

            if (string.IsNullOrEmpty(line)) continue;

            string[] values = line.Split(",");

            JopUpgradeInfo data = new JopUpgradeInfo();

            data.id = int.Parse(values[0]);
            data.upgradeStage = int.Parse(values[1]);
            data.effectDesc1 = values[2];
            data.effectDesc2 = values[3];
            data.effectDesc1Key = values[4];
            data.effectDesc2Key = values[5];

            int key = data.id;

            if (!JopUpgradeInfoDict.ContainsKey(key))
            {
                JopUpgradeInfoDict.Add(key, data);
            }
            else
            {
                Debug.LogWarning($"JopInfoDict 중복된 키 : {key} (줄 {i + 1})");
            }
        }
    }
    #endregion

    #region MonsterInfo
    public static void LoadMonsterInfo()
    {
        var csv = LoadCSV(MonsterListPath);

        if (string.IsNullOrEmpty(csv))
            return;

        MonsterInfoDict.Clear();

        string[] lines = csv.Split('\n');

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i].Trim();

            if (string.IsNullOrEmpty(line)) continue;

            string[] values = line.Split(",");

            MonsterInfo data = new MonsterInfo();

            data.id = int.Parse(values[0]);
            data.name = values[1];
            data.monsterType = int.Parse(values[2]);
            data.baseAtkType = int.Parse(values[3]);
            data.moveType = int.Parse(values[4]);
            data.bodyHitDam = int.Parse(values[5]);
            data.baseHp = float.Parse(values[6]);
            data.baseAtk = float.Parse(values[7]);
            data.atkCD = float.Parse(values[8]);
            data.nameKey = values[9];

            int key = data.id;

            if (!MonsterInfoDict.ContainsKey(key))
            {
                MonsterInfoDict.Add(key, data);
            }
            else
            {
                Debug.LogWarning($"MonsterInfo 중복된 키 : {key} (줄 {i + 1})");
            }
        }
    }
    #endregion

    #region MonsterPattern
    public static void LoadMonsterPattern()
    {
        var csv = LoadCSV(MonsterPatternPath);

        if (string.IsNullOrEmpty(csv))
            return;

        MonsterPatternDict.Clear();

        string[] lines = csv.Split('\n');

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i].Trim();

            if (string.IsNullOrEmpty(line)) continue;

            string[] values = line.Split(",");

            MonsterPattern data = new MonsterPattern();

            data.id = int.Parse(values[0]);
            data.patternNo = int.Parse(values[1]);
            data.cooldown = float.Parse(values[2]);
            data.rangeType = int.Parse(values[3]);
            data.effectType = int.Parse(values[4]);
            data.effectValue = float.Parse(values[5]);
            data.duration = float.Parse(values[6]);
            data.condition = int.Parse(values[7]);
            data.conditionValue = float.Parse(values[8]);
            data.phase = int.Parse(values[9]);

            int key = data.id * 100 + data.id + i;

            if (!MonsterPatternDict.ContainsKey(key))
            {
                MonsterPatternDict.Add(key, data);
            }
            else
            {
                Debug.LogWarning($"MonsterPattern 중복된 키 : {key} (줄 {i + 1})");
            }
        }
    }
    #endregion


    #region MonsterPhase
    public static void LoadMonsterPhase()
    {
        var csv = LoadCSV(MonsterPhasePath);

        if (string.IsNullOrEmpty(csv))
            return;

        MonsterPhaseDict.Clear();

        string[] lines = csv.Split('\n');

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i].Trim();

            if (string.IsNullOrEmpty(line)) continue;

            string[] values = line.Split(",");

            MonsterPhase data = new MonsterPhase();

            data.id = int.Parse(values[0]);
            data.phase = int.Parse(values[1]);
            data.changeHP = float.Parse(values[2]);

            int key = data.id * 100 + data.id + i;

            if (!MonsterPhaseDict.ContainsKey(key))
            {
                MonsterPhaseDict.Add(key, data);
            }
            else
            {
                Debug.LogWarning($"MonsterPattern 중복된 키 : {key} (줄 {i + 1})");
            }
        }
    }
    #endregion
}
