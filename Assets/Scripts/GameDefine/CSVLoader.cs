using System.Collections.Generic;
using UnityEngine;

public class CSVLoader : MonoBehaviour
{
    private const string SynergyTagPath = "CSV/synergy_tags";
    private const string ItemListPath = "CSV/item_list";
    private const string GrowthUpgradePath = "CSV/growth_upgrade";

    public static Dictionary<int, SynergyTagData> SynergyTagDict = new();
    public static Dictionary<int, ItemCSV> ItemCSVDict = new();
    public static Dictionary<int, GrowthUpgrade> GrowthUpgradeDict = new();

    private void Awake()
    {
        AllCSVLoad();
    }

    public static void AllCSVLoad()
    {
        LoadSynergyTag();
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

    #region Load

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
        var csv = LoadCSV(ItemListPath);

        if (string.IsNullOrEmpty(csv))
            return;

        ItemCSVDict.Clear();

        string[] lines = csv.Split('\n');

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i].Trim();

            if (string.IsNullOrEmpty(line)) continue;

            string[] values = line.Split(",");

            ItemCSV data = new ItemCSV();

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

            if (!ItemCSVDict.ContainsKey(key))
            {
                ItemCSVDict.Add(key, data);
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

    #endregion
}
