using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TankScriptableObject", menuName = "ScriptableObjects/NewTankSO")]
public class TankScriptableObject : ScriptableObject
{
    public TankType tankType;
    public BulletType bulletType;
    public string TankName;
    public float speed;
    public int health;
    public float rotationSpeed;
    public float TurretRotationSpeed;
    public int bulletsFired;
    public int enemiesKilled;
}
