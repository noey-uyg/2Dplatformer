using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalPortal : InteractablePortal
{
    public override void OnEnterPortal()
    {
        var mapInfo = MapManager.Instance.GetNextRandomMap();

        if (mapInfo == null)
            return;

        MapManager.Instance.LoadMapPrefab(mapInfo);
    }
}
