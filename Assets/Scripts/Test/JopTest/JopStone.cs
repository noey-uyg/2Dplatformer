using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JopStone : InteractableStone
{
    private List<JopInfo> _jopInfos = new List<JopInfo>();
    private JopInfo _currentJop;

    private void Start()
    {
        RerollJop();
    }

    public override void OnReroll()
    {
        RerollJop();
    }

    public override void OnSelect()
    {
        if (PlayerData.CurrentJop != null)
            return;

        if(_currentJop != null)
        {
            PlayerController.Instance.SetJop(_currentJop.id);
            Debug.Log($"���� ���� �Ϸ� {_currentJop.name}");
        }
    }

    private void RerollJop()
    {
        if (PlayerData.CurrentJop != null)
            return;

        if (_jopInfos.Count == 0)
            _jopInfos = DataManager.GetAllJopInfos();

        if (_jopInfos.Count == 0)
            return;

        _currentJop = _jopInfos[Random.Range(0, _jopInfos.Count)];
        Debug.Log($"���� ��� : {_currentJop.name}");

        // TO DO...UI ������Ʈ
    }
}
