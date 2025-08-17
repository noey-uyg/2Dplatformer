using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class MonsterPool : Singleton<MonsterPool>
{
    [SerializeField] private List<MonsterBase> monsterPrefabs;

    private Dictionary<int, ObjectPool<MonsterBase>> _monsterPools = new Dictionary<int, ObjectPool<MonsterBase>>();
    private const int maxSize = 200;
    private const int initSize = 20;

    protected override void OnAwake()
    {
        foreach(var prefab in monsterPrefabs)
        {
            int id = prefab.MonsterID;
            _monsterPools[id] = new ObjectPool<MonsterBase>(
                () => CreateMonster(prefab)
                );
        }
    }

    private MonsterBase CreateMonster(MonsterBase prefab)
    {
        var monster = Instantiate(prefab);
        monster.gameObject.SetActive(false);
        return monster;
    }

    private void ActivatieMonster(MonsterBase monster) => monster.gameObject.SetActive(true);
    private void DeactivateMonster(MonsterBase monster) => monster.gameObject.SetActive(false);
    private void DestroyMonster(MonsterBase monster) => Destroy(monster);

    public MonsterBase GetMonster(int monsterID)
    {
        if (_monsterPools.TryGetValue(monsterID, out var pool)) return pool.Get();

        Debug.LogError($"Monster ID : {monsterID} not found in pool");
        return null;
    }

    public void ReleaseMonster(MonsterBase monster)
    {
        if (_monsterPools.TryGetValue(monster.MonsterID, out var pool))
            pool.Release(monster);
        else
            Destroy(monster.gameObject);
    }
}
