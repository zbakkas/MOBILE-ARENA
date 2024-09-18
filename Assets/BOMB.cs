using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOMB : MonoBehaviour
{

    public Transform bulletSpawnPoint,enemey;
    public GameObject bulletPrefab;
    public float bulletSpeed ;

    //
    public Vector3 dirction;
    public float Force,masafa;
    public GameObject prefab;
    public GameObject[] preffabbs;
     int numpper =40;
    public float n, current2;
    public Vector3 current;

    // Start is called before the first frame update
    void Start()
    {
        preffabbs = new GameObject[numpper];
        for(int i = 0; i < numpper; i++)
        {
            preffabbs[i] = Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        n = current.x-transform.position.x;
        masafa =  enemey.position.x- transform.position.x;
       
            if (Input.GetKeyDown(KeyCode.Space))
            {


             
                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
                   
                   
                    //
             

               


            }
        fasmous();
       

        for (int i = 0; i <preffabbs.Length; i++)
        {
            preffabbs[i].transform.position = pintiton(i * 0.1f);
            pintiton2(i * 0.1f);
            if (preffabbs[i].transform.position.y >= 0)
            {
               
                
            }
            if (preffabbs[i].transform.position.y < 0)
            {
                numpper = i;

                break;
            }
        }

    }
    void fasmous()
    {
        transform.forward = dirction;
    }


    Vector3 pintiton(float t)
    {

        current = (Vector3)transform.position+ (dirction.normalized * Force * t) + 0.5f * Physics.gravity * (t * t);
        return current;
    }
    void pintiton2(float t)
    {

        current2 = transform.position.x + (dirction.normalized.x * n * t) + 0.5f * Physics.gravity.x * (t * t);
      
    }


}
