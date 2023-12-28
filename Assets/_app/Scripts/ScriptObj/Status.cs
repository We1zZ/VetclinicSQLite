using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Status")]
public class Status : ScriptableObject
{
    public bool[] OffStatus = new bool [20];  
}
