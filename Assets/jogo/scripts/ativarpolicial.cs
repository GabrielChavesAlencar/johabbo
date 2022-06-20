using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ativarpolicial : MonoBehaviour
{
    public GameObject carro1;
    public GameObject carro2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="carro"){
            carro1.SetActive(true);
            carro2.SetActive(true);
        }
    }
}
