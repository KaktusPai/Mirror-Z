using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClassHandler : MonoBehaviour
{
    // Current players class ID
    public int playerClassID;
    // Classes player data
    public List<Object> classesData;
   
    public object GetPlayerClassData()
    {
        return classesData[playerClassID];
    }
}
