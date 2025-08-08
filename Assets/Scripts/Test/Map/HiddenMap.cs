using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenMap : BaseMap
{
    private MapInfo _returnMap;

    public void SetReturnMap(MapInfo map)
    {
        _returnMap = map;
    }

    public override void OnMapClear()
    {
        Debug.Log("���� �� Ŭ���� - ���� ������ �̵�");
    }

    public MapInfo GetReturnMap()
    {
        return _returnMap;
    }
}
