using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawnManager : MonoBehaviour
{
    [System.Serializable]
    public class SpawnPoint
    {
        public int spawnID;
        public Transform Point;
    }

    [SerializeField] private int _currentMapID;
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    private List<MonsterSpawn> _spawnDataList;
    private List<MonsterBase> _aliveMonsters = new List<MonsterBase>();
    private BaseMap _curMap;

    public void Initialize(List<MonsterSpawn> spawnData, BaseMap curMap)
    {
        _currentMapID = curMap.MapID;
        _curMap = curMap;
        _spawnDataList = spawnData.FindAll(r => r.mapID == _currentMapID);
    }

    public void SpawnAll()
    {
        _aliveMonsters.Clear();

        foreach (var v in _spawnDataList)
        {
            var point = _spawnPoints.Find(r => r.spawnID == v.spawnID)?.Point;
            if(point == null)
            {
                Debug.LogWarning($"Spawn point {v.spawnID} not found");
                continue;
            }

            var monster = MonsterPool.Instance.GetMonster(v.monsterID);
            if(monster != null)
            {
                monster.transform.position = point.position;
                monster.Initialize(DataManager.GetMonsterData(v.monsterID));

                monster.OnDeath += HandleMonsterDeath;
                _aliveMonsters.Add(monster);
            }
        }
    }

    private void HandleMonsterDeath(MonsterBase monster)
    {
        if(_aliveMonsters.Contains(monster))
            _aliveMonsters.Remove(monster);

        if(_aliveMonsters.Count == 0)
        {
            Debug.Log($"[MonsterSpawnManager] Map {_currentMapID} Clear");
            _curMap?.OnMapClear();
        }
    }
}
