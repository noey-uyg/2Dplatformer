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
    /// ���� ����
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
    /// ����
    /// </summary>
    public static void Promotion()
    {
        int nextUpgradeStage = _upgradeStage + 1;

        if (DataManager.GetJopUpgrade(_currentJop.id, nextUpgradeStage) == null)
        {
            Debug.LogError("�̹� ������ ���� �ܰ��Դϴ�.");
            return;
        }

        _upgradeStage++;
        LoadCurrentJopSkill();
    }

    private static void LoadCurrentJopSkill()
    {
        _currentJopSkill.Clear();

        _currentJopSkill = DataManager.GetJopSkills(_currentJop.id, _upgradeStage);

        Debug.Log($"���� {_currentJop.name} ����");
        foreach (var v in _currentJopSkill)
        {
            Debug.Log($"��ų ���� [{v.slot}] : {v.name}�� ���� {v.upgradeStage}");
        }
    }
}
