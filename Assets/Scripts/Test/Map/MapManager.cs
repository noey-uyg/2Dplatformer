using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MapManager : DontDestroySingleton<MapManager>
{
    private List<int> _usedMaps = new List<int>();
    private int _currentStageID = 1;
    private int _clearedStageMaps;
    private bool _hiddenMapVisited;

    private List<MapInfo> _allMaps;
    private List<MapInfo> _normalMaps;
    private MapInfo _hiddenMap;
    private MapInfo _bossMap;
    private MapInfo _shopMap;

    public void InitStage(int stageID)
    {
        _currentStageID = stageID;
        _clearedStageMaps = 0;
        _hiddenMapVisited = false;
        _usedMaps.Clear();
        _allMaps.Clear();

        _allMaps = DataManager.GetAllMaps()
                    .FindAll(r => r.stageID == stageID);

        _normalMaps = _allMaps.FindAll(r => r.mapType == 1);
        _hiddenMap = _allMaps.Find(r => r.mapType == 2);
        _bossMap = _allMaps.Find(r => r.mapType == 3);
        _shopMap = _allMaps.Find(r => r.mapType == 4);
    }

    public MapInfo GetNextRandomMap()
    {
        // ½ÃÀÛ ¸Ê Ã³¸®
        if (_clearedStageMaps == 0 && _currentStageID == 1 && !_hiddenMapVisited)
            return _allMaps.Find(r => r.mapType == 0);

        if(_clearedStageMaps < 4)
        {
            var available = _normalMaps.Where(r => !_usedMaps.Contains(r.mapID)).ToList();
            var selected = available[Random.Range(0, available.Count)];
            _usedMaps.Add(selected.mapID);
            _clearedStageMaps++;
            return selected;
        }

        if(_clearedStageMaps == 4)
        {
            _clearedStageMaps++;
            return _bossMap;
        }

        if(_clearedStageMaps == 5)
        {
            return _shopMap;
        }

        return null;
    }

    public MapInfo GetHiddenMap()
    {
        if (_hiddenMapVisited || _hiddenMap == null)
            return null;

        _hiddenMapVisited = true;
        return _hiddenMap;
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
