using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMap : BaseMap
{
    public override void OnMapClear()
    {
        Debug.Log("상점 끝 - 다음 스테이지로 이동");
        //MapManager.Instance.InitStage(MapManager.Instance.CurrentStage+1);
        //MapManager.Instance.GetNextRandomMap();
    }
}
