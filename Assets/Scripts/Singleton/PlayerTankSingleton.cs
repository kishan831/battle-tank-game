using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTankSingleton : MonoBehaviour
{
    private static PlayerTankSingleton instance;
    public PlayerTankSingleton Instance { get { return instance; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
}
