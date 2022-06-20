using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selecionar : MonoBehaviour
{
    public GameObject coruja;
    public GameObject monkey;
    public GameObject aperip;
    public GameObject richape;
    public GameObject snupdog;
    public GameObject apeatleta;
    public GameObject apeastro;
    public GameObject apepolice;


    void Start()
    {
        
        if(selecionado.sele==1)
        {monkey.SetActive(true);}   
        if(selecionado.sele==2)
        {coruja.SetActive(true);}  
        if(selecionado.sele==3)
        {aperip.SetActive(true);}
        if(selecionado.sele==4)
        {richape.SetActive(true);}
        if(selecionado.sele==5)
        {snupdog.SetActive(true);}
        if(selecionado.sele==6)
        {apeatleta.SetActive(true);}
        if(selecionado.sele==7)
        {apeastro.SetActive(true);}
        if(selecionado.sele==8)
        {apepolice.SetActive(true);}
    }

}
