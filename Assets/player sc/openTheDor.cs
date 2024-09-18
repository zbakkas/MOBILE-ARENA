using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openTheDor : MonoBehaviour
{
    public RANGshoot r;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (r.nearso == null)
            {
                //next level
                Debug.Log("next level");
            }
            else
            {
                Debug.Log("you dont hav all keys");
            }

        }

    }
}
