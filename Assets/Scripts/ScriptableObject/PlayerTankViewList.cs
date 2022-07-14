using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "PlayerTankViewList", menuName = "ScriptableObjects/NewPlayerTankViewList")]
public class PlayerTankViewList : ScriptableObject
{
    public List<TankView> TankViewList;
}
