using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posicaoolho : MonoBehaviour
{
     public GameObject cabeça;
     public GameObject cabeçarot;
     public Vector3 ajustedepos;
    public Vector3 ajustederot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate() 
    {
        transform.position = new Vector3(
            cabeça.transform.position.x+ajustedepos.x,
            cabeça.transform.position.y+ajustedepos.y,
            cabeça.transform.position.z+ajustedepos.z
        );
        //transform.localRotation =  Quaternion.Euler(0, 88, 0);
        transform.eulerAngles = new Vector3(
            cabeçarot.transform.eulerAngles.x+ajustederot.x,
            cabeçarot.transform.eulerAngles.y+ajustederot.y,
            cabeçarot.transform.eulerAngles.z+ajustederot.z
        );
    }
}
