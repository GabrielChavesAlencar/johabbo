using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cancela : MonoBehaviour
{
    public bool aberto;
    private Animator anim;
    public BoxCollider box;

    public AudioSource som;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        box =  GetComponent<BoxCollider>();
        som = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(aberto){anim.Play("cancelaberto");box.enabled =false;}
        else{anim.Play("cancelafechado");box.enabled =true;}
    }
}
