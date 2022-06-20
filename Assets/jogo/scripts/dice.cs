using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dice : MonoBehaviour
{
    // Start is called before the first frame update
     private Animator anim;

     public bool aberto;
     public int resultado;
         public AudioSource som;
    void Start()
    {  
         anim = GetComponent<Animator>();
         som = GetComponent<AudioSource>();
         
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sortearnumero()
    {
        if(aberto)
        {
            anim.Play("semovendo");
             StartCoroutine(nsorteado());
        }
    }

    public void abrir()
    {
       
            anim.Play("abrir");
            som.Play();
            aberto = true;
       
    }
     public void fechar()
    {
       
            anim.Play("fechar");
            som.Play();
            aberto = false;
       
    }



    IEnumerator nsorteado() {
        
        
                

                    yield return new WaitForSeconds(3f);
                    resultado = Random.Range(1,7);
                    anim.Play(resultado+"");
                   
     }

















}
