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
            Debug.LogWarning("�� �̻� ������ �� �ִ� ���� �����ϴ�.");
            return;
        }

        GameObject prefab = MapManager.Instance.LoadMapPrefab(MapInfo);

        if(prefab == null)
        {
            Debug.LogError($"�� ������ �ε� ���� : {MapInfo.mapPrefabName}");
            return;
        }

        Instantiate(prefab);
    }

    public override void OnReroll()
    {
        throw new System.NotImplementedException();
    }

}
