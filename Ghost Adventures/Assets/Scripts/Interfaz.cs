using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interfaz : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Gvidas;
    public GameObject Gcronometro;
    
    private int vidas;
    private int cronometro;
    void Start()
    {
        this.vidas=3;
        this.cronometro=0;
        this.Gvidas.GetComponent<Text>().text="Vidas: "+this.vidas;
    }

    // Update is called once per frame
    void Update()
    {
        
        this.Gcronometro.GetComponent<Text>().text="Time: "+this.cronometro++;
    }
    void OnTriggerEnter(Collider other)
    {  // print("estoy aqui");
        if(other.tag=="Enemigos")
        {   
            this.vidas--;
            this.Gvidas.GetComponent<Text>().text="Vidas: "+this.vidas;
        }
        if(other.tag=="aumentoVida")
        {   
            this.vidas=this.vidas+1;
            print(this.vidas);
            this.Gvidas.GetComponent<Text>().text="Vidas: "+this.vidas;
            //Destroy(this.GetComponent,3f);
        }
        
        if(other.tag=="Granada"){
            this.vidas--;
            this.Gvidas.GetComponent<Text>().text="Vidas: "+this.vidas;
        }

        
    }
    
}
