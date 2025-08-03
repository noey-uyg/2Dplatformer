using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulSelectButton : MonoBehaviour
{
    [SerializeField] private int _soulID;

    public void SelectButtonClick()
    {
        PlayerController.Instance.SetSoul(_soulID);
    }
}
