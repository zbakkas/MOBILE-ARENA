using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombing : MonoBehaviour
{
    public float life = 3;
    public GameObject trasPrefab;

    // Start is called before the first frame update
    void Awake()
    {
        Destroy(gameObject, life);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        //Destroy(collision.gameObject);
       // Instantiate(trasPrefab, transform.position, transform.rotation);
      //  Destroy(gameObject);
    }
}
