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
    }

    private void TrySpawnHiddenPortal()
    {
        if (!MapManager.Instance.HiddenMapVisited && Random.value < 0.1f)
            Debug.Log("È÷µç Æ÷Å» »ý¼ºµÊ");
    }
}
