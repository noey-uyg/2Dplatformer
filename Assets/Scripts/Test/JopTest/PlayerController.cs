using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{
    [SerializeField] private Player _player;
    [SerializeField] private SkillManager _skillManager;

    /// <summary>
    /// ���� ����
    /// </summary>
    public void SetJop(int id)
    {
        var jopInfo = DataManager.GetJopInfo(id);

        if (jopInfo == null)
            return;

        PlayerData.SetJop(jopInfo);
        PlayerData.SetUpgradeStage(1);
        LoadCurrentJopSkill();
    }

    /// <summary>
    /// ����
    /// </summary>
    public void Promotion()
    {
        int nextUpgradeStage = PlayerData.UpgradeStage + 1;

        if (DataManager.GetJopUpgrade(PlayerData.CurrentJop.id, nextUpgradeStage) == null)
        {
            Debug.LogError("�̹� ������ ���� �ܰ��Դϴ�.");
            return;
        }

        PlayerData.SetUpgradeStage(nextUpgradeStage);
        LoadCurrentJopSkill();
    }

    private void LoadCurrentJopSkill()
    {
        var jopSkills = DataManager.GetJopSkills(
            PlayerData.CurrentJop.id,
            PlayerData.UpgradeStage);

        PlayerData.SetJopSkill(jopSkills);
        _skillManager.LoadPlayerSkills(jopSkills);
    }
}
