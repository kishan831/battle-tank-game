using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "BulletScriptableObjectList", menuName = "ScriptableObjects/NewBulletSOList")]
public class BulletScriptableObjectList : ScriptableObject
{
    public List<BulletScriptableObject> BulletSOList;
}
