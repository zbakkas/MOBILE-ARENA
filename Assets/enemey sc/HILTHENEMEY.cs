using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HILTHENEMEY : MonoBehaviour
{
    public int hilthEnemey;
    public enemy e;
    // Start is called before the first frame update
    void Start()
    {
        hilthEnemey = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(hilthEnemey <= 0)
        {
            e.anim.SetBool("death", true);
            //Destroy(gameObject);
            StartCoroutine(destroyenemey());
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        //Destroy(collision.gameObject);
        if (collision.gameObject.tag == "bultt")
        {
            hilthEnemey -= 40;
        }

    }

    IEnumerator destroyenemey()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
        
    }
}
