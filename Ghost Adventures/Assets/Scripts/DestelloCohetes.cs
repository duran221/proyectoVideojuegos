using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestelloCohetes : MonoBehaviour
{
    // Start is called before the first frame update
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
        if(other.tag== "Player"){
            this.Particula.GetComponent<ParticleSystem>().Play();
        }
    }
}
