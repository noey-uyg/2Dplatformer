using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���� �� ���� ����
/// </summary>
public class JopSystem : MonoBehaviour
{
    private JopInfo _currentJop;
    private int _upgradeStage = 1;
    private List<JopSkill> _currentJopSkill = new List<JopSkill>();

    public JopInfo CurrentJop { get { return _currentJop; } }
    public int UpgradeStage { get { return _upgradeStage; } }
    public List<JopSkill> CurrentJopSkill { get { return _currentJopSkill; } }

    public bool TryUpgrade()
    {
        int nextStage = _upgradeStage + 1;

        return true;
    }
}
