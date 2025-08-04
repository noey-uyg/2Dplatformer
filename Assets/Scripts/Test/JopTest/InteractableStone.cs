using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableStone : MonoBehaviour, IInteractableStone
{
    public abstract void OnReroll();

    public abstract void OnSelect();
}
