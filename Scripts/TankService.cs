using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This Class is respponsible to Create, Destroy and Manage all the Tank MVCs in the Game.
/// </summary>
public class TankService : SingletonGeneric<TankService>
{

    // UI & Camera refernces.
    public Joystick LeftJoyStick;
    public Joystick RightJoyStick;
    public Button FireButton;
    public Camera playerCamera;

    public TankMovement tankController;


    private void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        
    }

}
