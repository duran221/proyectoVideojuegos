using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarBalas : MonoBehaviour
{
    public GameObject ModeloBala;

    public GameObject Coordenadas1;
	private GameObject Destello,inicio;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Disparar2");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Disparar2() 
    {
        while (true) 
        {
            var Bala1 = Instantiate (this.ModeloBala,this.Coordenadas1.transform.position,this.Coordenadas1.transform.rotation)as GameObject;
        
        //	var Destello1=Instantiate (this.Destello,this.inicio.transform.position,inicio.transform.rotation)as GameObject;

    //		inicio.transform.parent=Destello1;
    //		Destello1.transform.parent=this.inicio.transform;

            Bala1.GetComponent<Rigidbody> ().AddForce (this.Coordenadas1.transform.forward *5000);
            
            //Destroy (Bala1, 0.1f);
            //Destroy (Bala2, 0.1f);
            yield return new WaitForSeconds(3);
        }
    }
}
