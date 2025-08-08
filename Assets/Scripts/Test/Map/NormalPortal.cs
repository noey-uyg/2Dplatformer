using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalPortal : InteractablePortal
{
    public override void OnEnterPortal()
    {
        var currentMap = MapManager.Instance.CurrentMap;

        MapInfo nextMap = null;

        if (currentMap == null)
        {
            Debug.Log("½ÃÀÛ ¸ÊÀÓ");
            MapManager.Instance.InitStage(1);
            nextMap = MapManager.Instance.GetNextRandomMap();
        }
        
        switch (currentMap)
        {
            case StartMap startMap:
            case ShopMap shopMap:
                {
                    MapManager.Instance.InitStage(MapManager.Instance.CurrentStage + 1);
                    nextMap = MapManager.Instance.GetNextRandomMap();
                    
                    break;
                }
            case BossMap bossMap:
                {
                    nextMap = MapManager.Instance.ShopMap;
                    break;
                }
            case NormalMap normalMap:
                {
                    nextMap = MapManager.Instance.GetNextRandomMap();
                    break;
                }
            case HiddenMap hiddenMap:
                {
                    nextMap = hiddenMap.GetReturnMap();                    
                    break;
                }
            default:
                Debug.LogWarning("¾Ë ¼ö ¾ø´Â ¸Ê Å¸ÀÔ");
                break;
        }

        if(nextMap != null)
        {
            MapManager.Instance.LoadMap(nextMap);
        }
        else
        {
            Debug.LogError("¸Ê ¾øÀ½");
        }

        //var mapInfo = MapManager.Instance.GetNextRandomMap();

        //if (mapInfo == null)
        //    return;

        //MapManager.Instance.LoadMap(mapInfo);
    }
}
