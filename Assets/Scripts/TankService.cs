using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This Class is respponsible to Create, Destroy and Manage all the Tank MVCs in the Game.
/// </summary>
public class TankService : SingletonGeneric<TankService>
{
    // Scriptable Object references.
    public PlayerTankViewList playerTankViewList;
    public TankScriptableObjectList TankList;
    public BulletScriptableObjectList BulletList;

    // UI & Camera refernces.
  
    public Button FireButton;
    public Camera playerCamera;

    public TankMovement tankController;


    private void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        tankController = CreateNewPlayerTank();
    }

    // This Function Creates a new Player Tank MVC & also set all the required references and returns the Tank Controller for the same.
    private TankMovement CreateNewPlayerTank()
    {
        TankModel tankModel = new TankModel(TankList.TankSOList[2]);
        TankMovement tankController = new TankMovement(tankModel, playerTankViewList.TankViewList[1]);
        tankController.SetCameraReference(playerCamera);
        tankController.TankView.SetTankControllerReference(tankController);
        return tankController;
    }

    // This Function is used to communicate with Bullet Service Script when input to fire a bullet is recieved.
    public void Fire()
    {
        BulletService.Instance.FireBullet(tankController.TankView.BulletSpawner.transform, tankController.TankModel.BulletType);
        EventHandler.Instance.InvokeOnBulletFired();
    }

}
