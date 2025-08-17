using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BaseMap : MonoBehaviour
{
    [SerializeField] private MonsterSpawnManager _monsterSpawnManager;

    [SerializeField] protected int _mapID;
    [SerializeField] protected Transform _playerSpawnPoint;
    [SerializeField] protected List<InteractablePortal> _portals;
    [SerializeField] protected Transform[] _monsterSpawnPoint;

    protected bool _isCleared;

    public int MapID { get { return _mapID; } }

    public virtual void InitMap()
    {
        _isCleared = false;
        SpawnPlayer();
        SetPortalsActive(false);

        if (_monsterSpawnManager == null)
            GetComponent<MonsterSpawnManager>();

        _monsterSpawnManager.Initialize(DataManager.GetMapSpawnData(_mapID), this);
        _monsterSpawnManager.SpawnAll();
    }

    protected void SpawnPlayer()
    {
        var player = PlayerController.Instance.GetPlayer();
        player.transform.position = _playerSpawnPoint.position;
    }

    public virtual void OnMapClear()
    {
        _isCleared = true;
        SetPortalsActive(true);
    }

    protected void SetPortalsActive(bool active)
    {
        foreach (var portal in _portals)
        {
            portal.gameObject.SetActive(active);
        }
    }
}
