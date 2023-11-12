using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    public GameObject effect;
    public UImanager manager;
    void Awake()
    {
        manager = GameObject.Find("GameManager").GetComponent<UImanager>();
   }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.transform.CompareTag("Player"))
        {
            manager.Defeat();
            print("Touch");
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(collider.gameObject);
        }
    }
    
       
    }
