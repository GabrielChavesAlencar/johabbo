using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class jogo : MonoBehaviour
{
    public GameObject cam;
    public GameObject coruja;
    public GameObject monkey;
    public GameObject aperip;
    public GameObject richape;
    public GameObject snupdog;
    public GameObject apeatleta;
    public GameObject apeastro;
    public GameObject apepolice;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ape()
    {
        cam.SetActive(false);
        monkey.SetActive(true);

        selecionado.sele=1;
    }
    
    public void owl()
    {
        cam.SetActive(false);
        coruja.SetActive(true);
        selecionado.sele=2;
    }
    public void rip()
    {
        cam.SetActive(false);
        aperip.SetActive(true);

        selecionado.sele=3;
    }
    public void rich()
    {
        cam.SetActive(false);
        richape.SetActive(true);

        selecionado.sele=4;
    }
    public void snup()
    {
        cam.SetActive(false);
        snupdog.SetActive(true);

        selecionado.sele=5;
    }
    public void atleta()
    {
        cam.SetActive(false);
        apeatleta.SetActive(true);

        selecionado.sele=6;
    }
    public void astro()
    {
        cam.SetActive(false);
        apeastro.SetActive(true);

        selecionado.sele=7;
    }
    public void police()
    {
        cam.SetActive(false);
        apepolice.SetActive(true);

        selecionado.sele=8;
    }


   
}
