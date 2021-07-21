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
        if(distancia>51){
            this.EstarAlerta();
        }

        if(distancia<15){
            this.DetectarPersonaje();
            this.Caminar();
            this.Atacar();
        }

        //Si la distancia es menor a 10
        if(distancia<50 && distancia>15){
            this.DetectarPersonaje();
            this.Caminar();
        }
    }
    void OnTriggerEnter(Collider other){
        if(other.tag=="Granada"){
            this.Particula.GetComponent<ParticleSystem>().Play();
            this.Morir();
            Destroy(this.gameObject,5f);
        }
    }

    void DetectarPersonaje(){
        //Voltear
        myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
        Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
        //Caminar
        myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
        //Lineas de debug que aparecen en la ventana Scene
        Debug.DrawLine (target.transform.position, transform.position, Color.red,  Time.deltaTime, false);
    }

    void EstarAlerta(){
        this.GetComponent<Animator>().SetInteger("caminar",0);
        this.GetComponent<Animator>().SetInteger("ataque",0);
    }

    void Caminar(){
        this.GetComponent<Animator>().SetInteger("caminar",1);
    }

    void Morir(){
        this.GetComponent<Animator>().SetInteger("morir",1);
    }

    void Atacar(){
        this.GetComponent<Animator>().SetInteger("caminar",0);
        this.GetComponent<Animator>().SetInteger("ataque",1);
    }

}
