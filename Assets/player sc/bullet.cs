using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float life = 3;
    public GameObject trasPrefab,damahenemey;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        //Destroy(collision.gameObject);
        if (collision.gameObject.tag== "Enemey")
        {
            Instantiate(damahenemey, transform.position, transform.rotation);
        }
        else if (collision.gameObject.tag == "Player")
        {
            Instantiate(damahenemey, transform.position, transform.rotation);
        }
        else
        {
            Instantiate(trasPrefab, transform.position, transform.rotation);
        }
        
        Destroy(gameObject);
    }
}
