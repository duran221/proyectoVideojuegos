using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interfaz : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Gvidas;
    public GameObject Gcronometro;
    public GameObject GameOver;
    private int vidas;
    private float cronometro;
    void Start()
    {
        this.vidas=3;
        this.cronometro=0.0f;
        this.cronometro=600;
        this.Gvidas.GetComponent<Text>().text="Vidas: "+this.vidas;
    }

    // Update is called once per frame
    void Update()
    {
        this.cronometro -= Time.deltaTime;
        this.Gcronometro.GetComponent<Text>().text="Time: "+this.cronometro++;
    }
    void OnTriggerEnter(Collider other)
    {  // print("estoy aqui");
        if(other.tag=="Enemigos")
        {   
            this.vidas--;
            this.Gvidas.GetComponent<Text>().text="Vidas: "+this.vidas;
        }

        if(this.vidas==-1){
            Time.timeScale = 0.2f;
            this.GameOver.SetActive(true);
            
            StartCoroutine("Carga");
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
     IEnumerator Carga()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(0);
        
    }
    
}
