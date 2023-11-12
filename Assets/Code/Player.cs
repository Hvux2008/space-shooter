using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int points;
    public GameObject bullet;
    public float waitTime = 2f;
    public float waitActual;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waitActual -= Time.deltaTime;
        Move();
        ShipAttack();
    }
    void Move()
    {
        if (Input.GetMouseButton(0)){
            Vector2 mousePos = Input.mousePosition;
            Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = realPos;
        }
 
    }

    private void ShipAttack()
    {
        if (Input.GetMouseButton(0) && waitActual <= 0)
        {
            waitActual = waitTime * gamemanager.attackSpeedMultiplier;
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }

}
