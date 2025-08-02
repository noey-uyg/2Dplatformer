using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private SkillManager _skillManager;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _skillManager.UseSkill(1);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _skillManager.UseSkill(2);
        }
    }
}
