using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SkillBase : MonoBehaviour
{
    protected JopSkill _skillData;
    protected bool _isOnCooldown = false;
    protected WaitForSeconds _waitForSeconds;

    public void Initialize(JopSkill data)
    {
        _skillData = data;
        OnInit();
    }

    protected virtual void OnInit()
    {
        _waitForSeconds = new WaitForSeconds(_skillData.cooldown);
    }

    public virtual void UseSkill()
    {

    }
}
