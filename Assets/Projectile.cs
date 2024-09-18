using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody projectile;
    public GameObject cursor;
    public Transform shootPoint;

    
    public int lineSegment = 10;
    public float flightTime = 1f;

    private Camera cam;

    private Vector3  pos;
    public RANGshoot rng;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
        LaunchProjectile();
    }

    void LaunchProjectile()
    {
        
      


        cursor.SetActive(true);
        //cursor.transform.position = hit.point + Vector3.up * 0.1f;

        //vo = CalculateVelocty(cursor.transform.position, shootPoint.position, flightTime);

        //Visualize(vo, cursor.transform.position); //we include the cursor position as the final nodes for the line visual position

        //transform.rotation = Quaternion.LookRotation(vo);

       /* if (Input.GetMouseButtonDown(0))
        {
            Rigidbody obj = Instantiate(projectile, shootPoint.position, Quaternion.identity);
            obj.velocity = rng.vo;
        }*/
       
    }

    //added final position argument to draw the last line node to the actual target
   /*void Visualize(Vector3 vo, Vector3 finalPos)
    {
        for (int i = 0; i < lineSegment; i++)
        {
            //pos = CalculatePosInTime(vo, (i / (float)lineSegment) * flightTime);
            pos = cursor.transform.position;
          
        }

      
    }*/

    public Vector3 CalculateVelocty(Vector3 target, Vector3 origin, float time)
    {
        Vector3 distance = target - origin;
        Vector3 distanceXz = distance;
        distanceXz.y = 0f;

        float sY = distance.y;
        float sXz = distanceXz.magnitude;

        float Vxz = sXz / time;
        float Vy = (sY / time) + (0.5f * Mathf.Abs(Physics.gravity.y) * time);

        Vector3 result = distanceXz.normalized;
        result *= Vxz;
        result.y = Vy;

        return result;
    }

}
