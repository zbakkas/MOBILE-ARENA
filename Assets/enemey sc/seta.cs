using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seta : MonoBehaviour
{
    public GameObject tt;
    public bool t;
    // Start is called before the first frame update
    void Start()
    {
        t = false;
        tt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (t)
        {
            tt.SetActive(true);
        }
        if (!t)
        {
            tt.SetActive(false);
        }
    }

}
