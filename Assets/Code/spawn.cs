using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject spawnObject;
    public float waitTime = 2f;
    public float waitActual = 0f;
    // Update is called once per frame
    void Update()
    {
        float randX = Random.Range(-4f, 4f);
        Vector3 spawnPos = new Vector3(randX, transform.position.y, 0);
        waitActual -= Time.deltaTime;
        if (waitActual <= 0) {
            waitActual = waitTime;
            Instantiate(spawnObject, spawnPos, Quaternion.identity);


        }
    }
}
