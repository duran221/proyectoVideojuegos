using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPersigue : MonoBehaviour
{

    public Transform target; 
    public int moveSpeed = 3;
    private int rotationSpeed = 6;
    public GameObject Particula;

    public Transform myTransform;


    void Awake()
    {
        myTransform = transform;
    }


    void Start(){
        target = GameObject.FindWithTag("Player").transform; //target the player

    }


    void Update () {
        //Calcular distancia
        float distancia;
        distancia = Vector3.Distance(target.transform.position, transform.position);

        //Si la distancia es menor a 10
        if(distancia<25){
            //Voltear
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
            Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
            //Caminar
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
            //Lineas de debug que aparecen en la ventana Scene
            Debug.DrawLine (target.transform.position, transform.position, Color.red,  Time.deltaTime, false);
        }
    }
        void OnTriggerEnter(Collider other){
        if(other.tag=="Granada"){
            this.Particula.GetComponent<ParticleSystem>().Play();
            Destroy(this.gameObject,3f);
        }
    }

}
