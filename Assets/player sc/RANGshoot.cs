using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RANGshoot : MonoBehaviour
{
    /*  public float chaserenge;
      float distoenemey = Mathf.Infinity;
      public GameObject Enemey;
      // Start is called before the first frame update
      void Start()
      {
          Enemey = GameObject.FindGameObjectWithTag("Enemey");
      }

      // Update is called once per frame
      void Update()
      {
          distoenemey = Vector3.Distance(Enemey.transform.position, transform.position);
          if (distoenemey <= chaserenge )
          {

          }
      }

      private void OnDrawGizmos()
      {
          Gizmos.DrawWireSphere(transform.position, chaserenge);

      }*/

    public GameObject nearso = null;
    public Material sele;
    Material org;

    public float chaserenge;
    float distoenemey = Mathf.Infinity;
    public GameObject Enemey;
    public bool z =false;
    private Vector3 Vmovment1;

    public  Vector3 vo;
    public Projectile pr;
    private void Update()
    {
        GameObject[] Ennemey = GameObject.FindGameObjectsWithTag("Enemey");
        float destanc = 0f;
       
        foreach (GameObject obj in Ennemey)
        {
            
            Vector3 differ = obj.transform.position - transform.position;
           
                if (destanc == 0)
                {
                    destanc = differ.magnitude;
                    if (nearso != null)
                    {
                        nearso.GetComponent<seta>().t = false;
                    //rotation
                    Vmovment1 = obj.transform.position - transform.position;
                    //rang
                    distoenemey = Vector3.Distance(obj.transform.position, transform.position);
                    //SHOOTBOMB
                    vo = pr.CalculateVelocty(obj.transform.position, pr.shootPoint.position, pr.flightTime);
                }
                    nearso = obj;
                    nearso.GetComponent<seta>().t = false;
                }
                else if (destanc > differ.magnitude)
                {
                    destanc = differ.magnitude;
                    nearso.GetComponent<seta>().t = false;
                    nearso = obj;
                    nearso.GetComponent<seta>().t = false;
                //rotation
                Vmovment1 = obj.transform.position - transform.position;
                //rang
                distoenemey = Vector3.Distance(obj.transform.position, transform.position);
                //SHOOTBOMB
                vo = pr.CalculateVelocty(obj.transform.position, pr.shootPoint.position, pr.flightTime);
            }
            if (distoenemey <= chaserenge)
            {
                if (nearso.GetComponent<HILTHENEMEY>().hilthEnemey > 0)
                {
                    nearso.GetComponent<seta>().t = true;
                }
                //mobm
                if (Input.GetMouseButtonDown(0))
                {
                    Rigidbody tt = Instantiate(pr.projectile, pr.shootPoint.position, Quaternion.identity);
                    tt.velocity = vo;
                }

                //rotation

            }
            if (distoenemey > chaserenge || nearso.GetComponent<HILTHENEMEY>().hilthEnemey <= 0)
            {
                nearso.GetComponent<seta>().t = false;
            }
            
            



        }

    }
    public void shootpin()
    {
        if (distoenemey <= chaserenge && nearso != null)
        {
            //rotation
            Vector3 lookdirr = new Vector3(Vmovment1.x, Vmovment1.y, Vmovment1.z);
            transform.rotation = Quaternion.LookRotation(lookdirr);
        }
            
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, chaserenge);

    }
}
