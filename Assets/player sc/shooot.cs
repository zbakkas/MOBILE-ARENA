using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shooot : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    public Animator anim;

    public ParticleSystem ps;

    public float waittime ;
    public float _waittime;
    public RANGshoot rn;
    public FixedJoystick fj;
    float amo;
    public float ammo;
    public Text amotext;
    public GameObject buttonshot;
    public bool sho =false;

    private void Start()
    {
        amo = ammo;
    }
    private void Update()
    {
        amotext.text = amo.ToString();
     
        if (_waittime <= 0)
        {
           

        }
        else
        {
            _waittime -= Time.deltaTime;
            
        }

        if (sho)
        {
            if (fj.Horizontal == 0 && fj.Vertical == 0 && amo > 0)
            {
                

                if (_waittime <= 0)
                {
                    rn.shootpin();
                    var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                    bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
                    anim.SetBool("shoot", true);
                    ps.Play();
                    amo--;
                    //
                    _waittime = waittime;

                }
                else
                {
                    _waittime -= Time.deltaTime;

                }


            }
        }

    }
    public void shooting()
    {

        sho = true;


    }
    public void noshooting()
    {
        anim.SetBool("shoot", false);
        sho = false;
        
    }
    public void reelod()
    {
        if (amo < ammo)
        {
            buttonshot.SetActive(false);
            anim.SetTrigger("relod");
            StartCoroutine(with());
        }
    }
    IEnumerator with()
    {
        yield return new WaitForSeconds(1.4f);
        amo = ammo;
        buttonshot.SetActive(true);

    }
}
