using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMap : BaseMap
{
    private void Start()
    {
        InitMap();
    }

    public override void InitMap()
    {
        base.InitMap();
        Debug.Log("���� �� - ���� �ʱ� ����");
        MapManager.Instance.InitStartMap(this);
    }

    public void TryStartStage()
    {
        if (PlayerData.CurrentJop == null || PlayerData.CurrentSoul == null)
        {
            Debug.Log("������ ��ȥ ������ �ȵ�");
            return;
        }

        MapManager.Instance.InitStage(1);
        MapManager.Instance.GetNextRandomMap();
    }
}
