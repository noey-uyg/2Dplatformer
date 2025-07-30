using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    private static JopInfo _currentJop;
    private static List<JopSkill> _currentJopSkill = new List<JopSkill>();
    private static int _upgradeStage = 1;

    public static JopInfo CurrentJop { get { return _currentJop; } }
    public static List<JopSkill> CurrentJopSkill { get { return _currentJopSkill; } }
    public static int UpgradeStage { get {  return _upgradeStage; } }

    public static void SetJop(int id)
    {
        _currentJop = DataManager.GetJopInfo(id);

        _currentJopSkill.Clear();

        _currentJopSkill = DataManager.GetJopSkills(id, _upgradeStage);

        Debug.Log($"직업 {_currentJop.name} 선택");
        foreach(var v in _currentJopSkill)
        {
            Debug.Log($"스킬 슬롯 [{v.slot}] : {v.name}의 레벨 {v.upgradeStage}");
        }
    }
}
