using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMap : BaseMap
{
    public override void OnMapClear()
    {
        Debug.Log("���� �� - ���� ���������� �̵�");
        //MapManager.Instance.InitStage(MapManager.Instance.CurrentStage+1);
        //MapManager.Instance.GetNextRandomMap();
    }
}
