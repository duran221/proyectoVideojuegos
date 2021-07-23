using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public bool bandera;
    // Start is called before the first frame update
    void Start()
    {
        this.bandera = false;
    }

    // Update is called once per frame
    void Update()
    {
         transform.Rotate(0,250*Time.deltaTime,0);
         if(bandera)
         {
             Destroy(this.gameObject);
         }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {   
            this.bandera = true;
            //
        }
    }
          
}
