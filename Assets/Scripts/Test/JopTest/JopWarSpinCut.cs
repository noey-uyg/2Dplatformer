using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JopWarSpinCut : SkillBase
{
    public override void UseSkill()
    {
        if (_isOnCooldown)
        {
            Debug.Log("��ų�� ���� ��Ÿ�� ���Դϴ�.");
            return;
        }

        Debug.Log($"{_skillData.name} ���");
        StartCoroutine(CooldownCoroutin());
    }

    private IEnumerator CooldownCoroutin()
    {
        _isOnCooldown = true;

        yield return _waitForSeconds;

        _isOnCooldown = false;
    }
}
