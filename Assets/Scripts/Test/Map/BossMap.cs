using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMap : BaseMap
{
    public override void InitMap()
    {
        base.InitMap();
        Debug.Log("보스 등장");
    }

    public override void OnMapClear()
    {
        Debug.Log("보스 클리어");
    }
}
