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
            Debug.Log("선택할 영혼이 없습니다.");
            return;
        }

        PlayerController.Instance.SetSoul(_currentSoul.id);

        Debug.Log($"영혼 선택 완료 {_currentSoul.name}");
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
        Debug.Log($"리롤 결과 : {_currentSoul.name}");

        // TO DO...UI 업데이트
    }
}
