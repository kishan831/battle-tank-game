using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This Class is Attached to a Player Tank GameObject and is responsible for rendering and UI related work.
/// </summary>
public class TankView : MonoBehaviour, Damagable
{
    public GameObject Turret;
    public Transform BulletSpawner;
    private TankMovement tankController;

    private void Start()
    {
     
    }

    // Sets a reference to the corresponding TankController Script.
    public void SetTankControllerReference(TankMovement controller)
    {
        tankController = controller;
    }

    // Implements the method of IDamagable interface to be able to take damage.
    public void TakeDamage(int damage)
    {
        Debug.Log("Player Tank Taking Damage: " + damage, gameObject);
    }


}
