using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "TankScriptableObjectList", menuName = "ScriptableObjects/NewTankSOList")]
public class TankScriptableObjectList : ScriptableObject
{
    public List<TankScriptableObject> TankSOList;
}
