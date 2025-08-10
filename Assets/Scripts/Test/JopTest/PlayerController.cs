using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{
    [SerializeField] private Player _player;
    [SerializeField] private SkillManager _skillManager;

    public Player GetPlayer() { return _player; }
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

    /// <summary>
    /// ���� ��ų �ҷ�����
    /// </summary>
    private void LoadCurrentJopSkill()
    {
        var jopSkills = DataManager.GetJopSkills(
            PlayerData.CurrentJop.id,
            PlayerData.UpgradeStage);

        PlayerData.SetJopSkill(jopSkills);
        _skillManager.LoadPlayerSkills(jopSkills);
    }

    /// <summary>
    /// ��ȥ ����
    /// </summary>
    public void SetSoul(int id)
    {
        var soulInfo = DataManager.GetSoulInfo(id);

        if(soulInfo == null)
            return;

        var skill = DataManager.GetSoulSkill(id);

        Debug.Log($"���� : {soulInfo.name} ��ȥ�� ��ų�� {skill.name}");
        PlayerData.SetSoul(soulInfo);
        PlayerData.SetSoulSkill(skill);
    }
}
