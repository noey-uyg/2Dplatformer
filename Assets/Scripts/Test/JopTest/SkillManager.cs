using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    private Dictionary<int, SkillBase> _skills = new Dictionary<int, SkillBase>();

    public void LoadPlayerSkills(List<JopSkill> skillDatas)
    {
        foreach(var skill in _skills.Values)
        {
            if (skill != null)
                Destroy(skill);
        }

        _skills.Clear();

        foreach(var data in skillDatas)
        {
            var skill = CreateSkillInstance(data);
            if(skill != null)
            {
                _skills.Add(data.slot, skill);
            }
        }
    }

    private SkillBase CreateSkillInstance(JopSkill skillData)
    {
        var type = Type.GetType(skillData.className);
        
        if(type == null)
        {
            Debug.Log($"스킬 클래스를 찾을 수 없습니다. : {skillData.className}");
            return null;
        }

        GameObject skillObject = new GameObject($"Skill_{skillData.className}");
        skillObject.transform.SetParent(this.transform);

        var skillComponent = skillObject.AddComponent(type) as SkillBase;
        
        if(skillComponent != null)
        {
            skillComponent.Initialize(skillData);
        }

        return skillComponent;
    }

    public void UseSkill(int slot)
    {
        if(_skills.TryGetValue(slot, out var skill))
        {
            skill.UseSkill();
        }
    }
}
