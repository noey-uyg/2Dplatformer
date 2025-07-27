using System.Collections.Generic;
using UnityEngine;

public class CSVLoader : MonoBehaviour
{
    private const string SynergyTagPath = "CSV/synergy_tags";

    public static Dictionary<int, SynergyTagData> SynergyTagDict = new();

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
                Debug.LogWarning($"중복된 키 : {key} (줄 {i + 1})");
            }
        }
    }
    #endregion
}
