using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JopUpgradeButton : MonoBehaviour
{
    public void PromotionButtonClick()
    {
        PlayerController.Instance.Promotion();
    }
}
