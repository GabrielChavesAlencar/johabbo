using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirporta : MonoBehaviour
{
    public GameObject porta1;
    public GameObject porta2;

    public bool naarea;
    public bool port;
    // Start is called before the first frame update
    void Start()
    {
        port = true;
    }

    // Update is called once per frame
    void Update()
    {
        porta1.SetActive(port);
        porta2.SetActive(port);
        if(naarea)
        {
            if(Input.GetKey(KeyCode.Space))
            {
                 StartCoroutine(abrir());
            }
        }
        
    }
     private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Player"){
            naarea = true;
        }
    }
     private void OnTriggerStay(Collider other) {
         if(other.gameObject.tag=="Player"){
            naarea = true;
        }
     }
     private void OnTriggerExit(Collider other) {
         if(other.gameObject.tag=="Player"){
            naarea = false;
        }
     }
      IEnumerator abrir() 
     { 
         yield return new WaitForSeconds(0.5f);
        port=!port;
         
     }
}
