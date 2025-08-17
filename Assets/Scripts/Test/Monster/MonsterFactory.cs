using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MonsterFactory
{
    public static MonsterBase CreateMonster(MonsterInfo data, Transform parent = null)
    {
        GameObject go = new GameObject(data.name);
        if(parent != null) go.transform.SetParent(parent);

        MonsterBase monster = null;

        switch (data.monsterType)
        {
            case (int)MonsterType.Normal:
                monster = go.AddComponent<NormalMonster>();
                break;
            case (int)MonsterType.Elite:
                monster = go.AddComponent<EliteMonster>();
                break;
            case (int)MonsterType.Boss:
                monster = go.AddComponent<BossMonster>();
                break;
        }

        monster.Initialize(data);
        return monster;
    }
}
