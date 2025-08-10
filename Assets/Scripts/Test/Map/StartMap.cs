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
        Debug.Log("시작 맵 - 게임 초기 설정");
        MapManager.Instance.InitStartMap(this);
    }

    public void TryStartStage()
    {
        if (PlayerData.CurrentJop == null || PlayerData.CurrentSoul == null)
        {
            Debug.Log("직업과 영혼 선택이 안됨");
            return;
        }

        MapManager.Instance.InitStage(1);
        MapManager.Instance.GetNextRandomMap();
    }
}
