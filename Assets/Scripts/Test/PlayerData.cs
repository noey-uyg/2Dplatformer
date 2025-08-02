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

    public static void SetJop(JopInfo jopInfo)
    {
        _currentJop = jopInfo;
    }

    public static void SetUpgradeStage(int upgradeStage)
    {
        _upgradeStage = upgradeStage;
    }

    public static void SetJopSkill(List<JopSkill> jopSkills)
    {
        _currentJopSkill = jopSkills;
    }
}
