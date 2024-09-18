using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lyser : MonoBehaviour
{
    public LineRenderer lr;
    public Transform starpin,ply;
    public FixedJoystick joystickatck;
    //RaycastHit hit;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (joystickatck.Horizontal != 0 || joystickatck.Vertical != 0)
        {
            if (lr.gameObject.activeInHierarchy == false)
            {
                lr.gameObject.SetActive(true);
            }
            lr.SetPosition(0, starpin.position);
            RaycastHit hit;
            if (Physics.Raycast(transform.position, -transform.right, out hit))
            {
               
                if (hit.collider)
                {
                    lr.SetPosition(1, hit.point);
                }
                // if (hit.transform.tag == "Player")
                // {
                //   Destroy(hit.transform.gameObject);
                //  }
            }
            else
            {
                lr.SetPosition(1, -transform.right * 5000);
            }
        }
        else
        {
            lr.gameObject.SetActive(false);
        }
        
        /*  if (Mathf.Abs(joystickatck.Horizontal) > 0.5f || Mathf.Abs(joystickatck.Vertical) > 0.5f)
         {
             if (lr.gameObject.activeInHierarchy == false)
             {
                 lr.gameObject.SetActive(true);
             }
             transform.position = new Vector3(ply.position.x, 0, ply.position.z);
             starpin.position = new Vector3(joystickatck.Horizontal , 0, joystickatck.Vertical );
             transform.LookAt(new Vector3(starpin.position.x, 0, starpin.position.z));
             transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
             lr.SetPosition(0, transform.position);

             if (Physics.Raycast(transform.position, transform.right, out hit,))
             {
                 lr.SetPosition(1, transform.right *5000);
             }
         }*/



    }
}
