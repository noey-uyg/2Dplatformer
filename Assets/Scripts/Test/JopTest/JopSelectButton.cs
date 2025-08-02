using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JopSelectButton : MonoBehaviour
{
    [SerializeField] private int _jopID;
    [SerializeField] private int _jopNameKey;

    public void SelectButtonClick()
    {
        PlayerController.Instance.SetJop(_jopID);
    }
}
