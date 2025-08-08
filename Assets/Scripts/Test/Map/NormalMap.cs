using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalMap : BaseMap
{
    [SerializeField] private Transform _hiddenSpawnPosition;

    public override void InitMap()
    {
        base.InitMap();
        TrySpawnHiddenPortal();
        SpawnMonsters();
    }

    private void TrySpawnHiddenPortal()
    {
        if (!MapManager.Instance.HiddenMapVisited && Random.value < 0.1f)
            Debug.Log("히든 포탈 생성됨");
    }

    private void SpawnMonsters()
    {
        Debug.Log("몬스터 스폰 시작");
    }
}
