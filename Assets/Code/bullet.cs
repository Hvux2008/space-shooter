using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }

    public void shoot()
    {
       transform.Translate(0, speed * Time.deltaTime * gamemanager.attackSpeedMultiplier, 0);
    }
}
