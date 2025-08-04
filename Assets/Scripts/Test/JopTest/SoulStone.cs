using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulStone : InteractableStone
{
    private List<SoulInfo> _soulInfos = new List<SoulInfo>();
    private SoulInfo _currentSoul;

    private void Start()
    {
        RerollStone();
    }

    public override void OnReroll()
    {
        RerollStone();
    }

    public override void OnSelect()
    {
        if (PlayerData.CurrentSoul != null)
            return;

        if(_currentSoul == null)
        {
            Debug.Log("������ ��ȥ�� �����ϴ�.");
            return;
        }

        PlayerController.Instance.SetSoul(_currentSoul.id);

        Debug.Log($"��ȥ ���� �Ϸ� {_currentSoul.name}");
    }

    private void RerollStone()
    {
        if (PlayerData.CurrentSoul != null)
            return;

        if (_soulInfos.Count == 0)
            _soulInfos = DataManager.GetAllSoulInfos();

        if (_soulInfos.Count == 0)
            return;

        var filtered = _soulInfos.FindAll(r => r.id != PlayerData.CurrentSoul?.id);

        if (filtered.Count == 0)
            filtered = _soulInfos;

        _currentSoul = filtered[Random.Range(0, filtered.Count)];
        Debug.Log($"���� ��� : {_currentSoul.name}");

        // TO DO...UI ������Ʈ
    }
}
