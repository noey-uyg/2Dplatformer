using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMap : BaseMap
{
    public override void InitMap()
    {
        base.InitMap();
        Debug.Log("���� ����");
    }

    public override void OnMapClear()
    {
        Debug.Log("���� Ŭ����");
    }
}
