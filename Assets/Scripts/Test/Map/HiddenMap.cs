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
        Debug.Log("히든 맵 클리어 - 원래 맵으로 이동");
    }

    public MapInfo GetReturnMap()
    {
        return _returnMap;
    }
}
