using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameradojogo : MonoBehaviour
{
   
    public Transform  alvo;
    public Vector3 distancia;
    public float speed;
    public Transform cameratranf;

    public Vector3 mousepos;


    void Start()
    {
       cameratranf= GetComponent<Transform>();

    }
     void Update()
    {
         if(Input.GetKeyDown(KeyCode.Alpha1))
        {
             SceneManager.LoadScene("car chase");
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
             SceneManager.LoadScene("casino");
        }
         if(Input.GetKeyDown(KeyCode.Alpha3))
        {
             SceneManager.LoadScene("space");
        }
         if(Input.GetKeyDown(KeyCode.Alpha4))
        {
             SceneManager.LoadScene("academia");
        }
    }



    void FixedUpdate()
    {
       

        transform.position = Vector3.Lerp(
            transform.position,
            alvo.position + distancia,
            speed*Time.deltaTime
            );

        mousepos = Input.mousePosition;
        distancia.z = mousepos.x/10;
        distancia.y = mousepos.y/10;
      

        transform.LookAt(alvo);

    }



}
