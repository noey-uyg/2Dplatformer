using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BaseMap : MonoBehaviour
{
    [SerializeField] protected int _mapID;
    [SerializeField] protected Transform _playerSpawnPoint;
    [SerializeField] protected List<InteractablePortal> _portals;

    protected bool _isCleared;

    public virtual void InitMap()
    {
        _isCleared = false;
        SpawnPlayer();
        SetPortalsActive(false);
    }

    protected void SpawnPlayer()
    {
        var player = PlayerController.Instance;
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
