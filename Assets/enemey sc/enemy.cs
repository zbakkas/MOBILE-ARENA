using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    public bool pin3;
    public Transform bulletSpawnPoint, bulletSpawnPoint2, bulletSpawnPoint3;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public Transform player;
    public float rangfolow;
    float distoplayer = Mathf.Infinity;
    float waittime;
    public float cwaitimeinime;
    public NavMeshAgent nav;
    public float navspeed;

    public Animator anim;
    public HILTHENEMEY h;
    float rangshoot ;
    public RI ri;
 
    private void Start()
    {
         rangshoot = ri.radius;
        
    }

    void Update()
    {
        
       


        distoplayer = Vector3.Distance(player.position, transform.position);
        if (distoplayer <= rangfolow && h.hilthEnemey > 0)
        {
            if (ri.canSeePlayer)
            {
                Vector3 movdir = player.transform.position - transform.position;
                float angle = Mathf.Atan2(movdir.x, movdir.z) * Mathf.Rad2Deg + movdir.y;
                transform.rotation = Quaternion.Euler(0, angle, 0);
            }
                //rotation
         
            //
            anim.SetBool("run", true);
            //falow
            nav.speed = navspeed;
            if (distoplayer <= rangshoot && ri.canSeePlayer)
            {
                anim.SetBool("run", false);
                nav.speed = 0;
                if (waittime <= 0)
                {
                    //shooting
                    if (pin3)
                    {
                        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;

                        var bullet2 = Instantiate(bulletPrefab, bulletSpawnPoint2.position, bulletSpawnPoint2.rotation);
                        bullet2.GetComponent<Rigidbody>().velocity = bulletSpawnPoint2.forward * bulletSpeed;

                        var bullet3 = Instantiate(bulletPrefab, bulletSpawnPoint3.position, bulletSpawnPoint3.rotation);
                        bullet3.GetComponent<Rigidbody>().velocity = bulletSpawnPoint3.forward * bulletSpeed;

                    }
                    else
                    {
                        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
                    }
                    
                    anim.SetBool("shoot", true);
                    
                    waittime = cwaitimeinime;
                }
                else
                {
                    anim.SetBool("shoot", false);
                    waittime -= Time.deltaTime;
                }
            }
            else
            {
                nav.speed = navspeed;
            }
            nav.SetDestination(player.position);
            

        }
        else
        {
            anim.SetBool("run", false);
            nav.speed = 0;
        }


    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, rangfolow);
        //Gizmos.DrawWireSphere(transform.position, rangshoot);
    }
}
