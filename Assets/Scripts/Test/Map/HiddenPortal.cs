using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenPortal : InteractablePortal
{
    public override void OnEnterPortal()
    {
        var mapInfo = MapManager.Instance.GetHiddenMap();
        
        if (mapInfo == null)
            return;

        MapManager.Instance.LoadMap(mapInfo);
    }
}
