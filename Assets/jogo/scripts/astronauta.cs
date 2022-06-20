using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class astronauta : MonoBehaviour
{
     public Rigidbody rig;
     public GameObject cam1;
     public GameObject cam2;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = new Vector3(0, -0.3f, 0);
        
    }

    // Update is called once per frame
    void Update()
    { 
         
        rig.AddForce(0,-0.1f,0);
        if(Input.GetKey(KeyCode.LeftArrow))
        {rig.AddForce(0,0,-0.5f);}
        if(Input.GetKey(KeyCode.RightArrow))
        {rig.AddForce(0,0,0.5f);}
         //rig.velocity = new Vector3(0, -2, 0);

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
          if(Input.GetKeyDown(KeyCode.Alpha5))
        {
             SceneManager.LoadScene("snupdog");
        }
         if(Input.GetKeyDown(KeyCode.Alpha6))
        {
             SceneManager.LoadScene("video1");
        }
    









         
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="camera"){
          cam1.SetActive(false);
          cam2.SetActive(true);
        }

          if(other.gameObject.tag=="chaospace"){
           SceneManager.LoadScene("space");
        }
         
    }













}
