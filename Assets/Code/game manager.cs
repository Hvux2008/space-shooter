using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public static float attackSpeedMultiplier = 1f;
    // Start is called before the first frame update
    public static void increaseMultiplier(float amount)
    {
        attackSpeedMultiplier *= amount;
    }
}

