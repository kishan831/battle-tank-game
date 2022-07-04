using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "BulletScriptableObject", menuName = "ScriptableObjects/NewBulletSO")]
public class BulletScriptableObject : ScriptableObject
{
    public BulletType bulletType;
    public float speed;
    public int Damage;
}
