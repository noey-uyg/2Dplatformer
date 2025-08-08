using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractablePortal : MonoBehaviour, IInteractablePortal
{
    public abstract void OnEnterPortal();
}
