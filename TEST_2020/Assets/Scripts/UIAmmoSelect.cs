using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAmmoSelect : MonoBehaviour 
{
    public AmmoDB ammoDB;
    void Awake()
    {
    ammoDB = (AmmoDB)Resources.Load("AmmoDB",typeof(AmmoDB));
    }
    public void SetAmmoIndex(int index)
    {
        ammoDB.index = index;
    }
}
