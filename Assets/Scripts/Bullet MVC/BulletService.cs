using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletService : SingletonGeneric<BulletService>
{
    public BulletScriptableObjectList bulletSOList;
    public BulletViewList bulletViewList;

    // This Function is used to Create a Bullet MVC which puts the bullet in motion as well.
    public void FireBullet(Transform BulletSpawner, BulletType bulletType)
    {
        BulletModel bulletModel = new BulletModel(bulletSOList.BulletSOList[(int)bulletType - 1]);
        BulletController bulletController = new BulletController(bulletModel, bulletViewList.bulletViewList[(int)bulletType - 1], BulletSpawner);
    }
}