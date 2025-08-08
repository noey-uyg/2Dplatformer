using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMap : BaseMap
{
    public override void InitMap()
    {
        base.InitMap();
        Debug.Log("���� �� - ���� �ʱ� ����");
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
