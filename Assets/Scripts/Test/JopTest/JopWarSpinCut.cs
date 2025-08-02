using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JopWarSpinCut : SkillBase
{
    public override void UseSkill()
    {
        if (_isOnCooldown)
        {
            Debug.Log("스킬은 현재 쿨타임 중입니다.");
            return;
        }

        Debug.Log($"{_skillData.name} 사용");
        StartCoroutine(CooldownCoroutin());
    }

    private IEnumerator CooldownCoroutin()
    {
        _isOnCooldown = true;

        yield return _waitForSeconds;

        _isOnCooldown = false;
    }
}
