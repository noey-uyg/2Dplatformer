using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{
    [SerializeField] private Player _player;
    [SerializeField] private SkillManager _skillManager;

    public Player GetPlayer() { return _player; }
    /// <summary>
    /// 직업 설정
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
    /// 전직
    /// </summary>
    public void Promotion()
    {
        int nextUpgradeStage = PlayerData.UpgradeStage + 1;

        if (DataManager.GetJopUpgrade(PlayerData.CurrentJop.id, nextUpgradeStage) == null)
        {
            Debug.LogError("이미 마지막 전직 단계입니다.");
            return;
        }

        PlayerData.SetUpgradeStage(nextUpgradeStage);
        LoadCurrentJopSkill();
    }

    /// <summary>
    /// 직업 스킬 불러오기
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
    /// 영혼 선택
    /// </summary>
    public void SetSoul(int id)
    {
        var soulInfo = DataManager.GetSoulInfo(id);

        if(soulInfo == null)
            return;

        var skill = DataManager.GetSoulSkill(id);

        Debug.Log($"선택 : {soulInfo.name} 영혼의 스킬은 {skill.name}");
        PlayerData.SetSoul(soulInfo);
        PlayerData.SetSoulSkill(skill);
    }
}
