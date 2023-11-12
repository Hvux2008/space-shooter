using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power : MonoBehaviour
{
    public GameObject effect;
        
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.transform.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}