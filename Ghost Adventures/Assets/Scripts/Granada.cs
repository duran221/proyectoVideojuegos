using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granada : MonoBehaviour
{
    public GameObject Particula;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        if( other.tag== "Enemigos"){
            this.Particula.GetComponent<ParticleSystem>().Play();
            Destroy(this.gameObject,4f);
        }
    }
}
