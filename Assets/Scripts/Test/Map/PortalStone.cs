using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalStone : InteractableStone
{
    [SerializeField] private Transform _spawnPoint;

    public override void OnSelect()
    {
        var MapInfo = MapManager.Instance.GetNextRandomMap();

        if(MapInfo == null)
        {
            Debug.LogWarning("더 이상 선택할 수 있는 맵이 없습니다.");
            return;
        }

        GameObject prefab = MapManager.Instance.LoadMapPrefab(MapInfo);

        if(prefab == null)
        {
            Debug.LogError($"맵 프리팹 로드 실패 : {MapInfo.mapPrefabName}");
            return;
        }

        Instantiate(prefab);
    }

    public override void OnReroll()
    {
        throw new System.NotImplementedException();
    }

}
