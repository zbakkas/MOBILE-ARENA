using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hilthPlayer : MonoBehaviour
{
    public float hilthplayer;
    public Animator anm;
    public Slider slid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slid.value = hilthplayer/100;
        if (hilthplayer < 0)
        {
            anm.SetBool("death", true);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        //Destroy(collision.gameObject);
        if (collision.gameObject.tag == "bultt")
        {
            hilthplayer -= 10;

        }

    }
}
