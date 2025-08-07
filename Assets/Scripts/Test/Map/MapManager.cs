using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : DontDestroySingleton<MapManager>
{
    private List<int> _usedMaps = new List<int>();
    private int _currentStageID = 1;
    private List<MapInfo> _allMaps => DataManager.GetAllMaps();

    public void InitStage(int stageID)
    {
        _currentStageID = stageID;
        _usedMaps.Clear();
    }

    public MapInfo GetNextRandomMap()
    {
        var candidates = _allMaps.FindAll(r => r.stageID == _currentStageID && !_usedMaps.Contains(r.mapID));

        Debug.Log(candidates.Count);
        if (candidates.Count == 0)
            return null;

        MapInfo selected = candidates[Random.Range(0, candidates.Count)];
        _usedMaps.Add(selected.mapID);

        return selected;
    }

    public GameObject LoadMapPrefab(MapInfo map)
    {
        string path = $"{map.prefabPath}/{map.mapPrefabName}";

        return Resources.Load<GameObject>(path);
    }

    public bool IsAllStageMapsUsed()
    {
        return _allMaps.FindAll(r => r.stageID == _currentStageID).Count == _usedMaps.Count;
    }

    public void ForceAddMap(int mapID)
    {
        if (!_usedMaps.Contains(mapID))
            _usedMaps.Add(mapID);
    }
}
