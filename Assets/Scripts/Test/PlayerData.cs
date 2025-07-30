using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerData
{
    private static JopInfo _currentJop;
    private static List<JopSkill> _currentJopSkill = new List<JopSkill>();
    private static int _upgradeStage = 1;

    public static JopInfo CurrentJop { get { return _currentJop; } }
    public static List<JopSkill> CurrentJopSkill { get { return _currentJopSkill; } }
    public static int UpgradeStage { get {  return _upgradeStage; } }

    /// <summary>
    /// 직업 설정
    /// </summary>
    public static void SetJop(int id)
    {
        _currentJop = DataManager.GetJopInfo(id);

        if (_currentJop == null)
            return;

        _upgradeStage = 1;
        LoadCurrentJopSkill();
    }

    /// <summary>
    /// 전직
    /// </summary>
    public static void Promotion()
    {
        int nextUpgradeStage = _upgradeStage + 1;

        if (DataManager.GetJopUpgrade(_currentJop.id, nextUpgradeStage) == null)
        {
            Debug.LogError("이미 마지막 전직 단계입니다.");
            return;
        }

        _upgradeStage++;
        LoadCurrentJopSkill();
    }

    private static void LoadCurrentJopSkill()
    {
        _currentJopSkill.Clear();

        _currentJopSkill = DataManager.GetJopSkills(_currentJop.id, _upgradeStage);

        Debug.Log($"직업 {_currentJop.name} 선택");
        foreach (var v in _currentJopSkill)
        {
            Debug.Log($"스킬 슬롯 [{v.slot}] : {v.name}의 레벨 {v.upgradeStage}");
        }
    }
}
