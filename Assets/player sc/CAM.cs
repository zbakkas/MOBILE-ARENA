using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAM : MonoBehaviour
{
    public Transform player;
    public float X,Y,Z;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
       
    {
       
        float upp = player.position.x ;
        float lefthandRith = player.position.z;
        float let=0;



        if (player.position.x >= 5.850453)
        {
            if(lefthandRith >= -57.08632)
            {
                let = -57.58632f-Z;
            }
            else if(lefthandRith <= -100)
            {
                let = -100;
            }
            else
            {
                let = player.position.z ;
            }
            transform.position = new Vector3(22.05f, player.position.y + Y, let+Z);
        }
        else
        {
            if (lefthandRith >= -57.08632)
            {
                let = -57.58632f-Z;
            }
            else if (lefthandRith <= -100)
            {
                let = -100;
            }
            else
            {
                let = player.position.z ;
            }
            transform.position = new Vector3(player.position.x + X, player.position.y + Y, let+Z);
        }
        

    }
}
