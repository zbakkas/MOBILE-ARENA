using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlPlayer : MonoBehaviour
{

    public CharacterController ch;
    private float inputX, inputZ;
    private Vector3 Vmovment, Vmovment1;
    public float movespeed, gavity;

    public FixedJoystick _joystick, _joystick1;
    public bool t, f;
    public Transform mish;
    //public shooot sh;

    public Animator anim;

   // public ParticleSystem ps;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //inputX = Input.GetAxis("Horizontal");
        // inputZ = Input.GetAxis("Vertical");
        /* if (_joystick1.Horizontal != 0 || _joystick1.Vertical != 0)
         {

             //
             t = true;
             Vmovment1 = new Vector3(_joystick1.Horizontal * movespeed, Vmovment1.y, _joystick1.Vertical * movespeed);
             Vector3 lookdirr = new Vector3(Vmovment1.x, Vmovment1.y, Vmovment1.z);
             mish.rotation = Quaternion.LookRotation(lookdirr);

         }

        if ((_joystick1.Horizontal == 0 || _joystick1.Vertical == 0)&&t)
        {
            f = true;
            anim.SetBool("shoot", true);
            ps.Play();
            sh.shooting();
            t = false;

        }
        else
        {
            anim.SetBool("shoot", false);
        }*/
     
    }
    private void FixedUpdate()
    {
       
            if (ch.isGrounded)
            {
                Vmovment.y = 0f;

            }
            else
            {
                Vmovment.y -= gavity * Time.deltaTime;

            }
            Vmovment = new Vector3(_joystick.Vertical * -movespeed, Vmovment.y, _joystick.Horizontal * movespeed);
            ch.Move(Vmovment);

            if ((_joystick.Horizontal != 0 || _joystick.Vertical != 0) && !t)
            {
                anim.SetBool("run", true);
                Vmovment1 = new Vector3(_joystick.Vertical * -movespeed, Vmovment1.y, _joystick.Horizontal * movespeed);
                Vector3 lookdirr = new Vector3(Vmovment1.x, Vmovment1.y, Vmovment1.z);
                mish.rotation = Quaternion.LookRotation(lookdirr);
            }
            else
            {
                anim.SetBool("run", false);
            }
        
        
    }
}
