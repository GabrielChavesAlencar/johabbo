using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mudardetela : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
         if(Input.GetKeyDown(KeyCode.Alpha5))
        {
             SceneManager.LoadScene("snupdog");
        }
         if(Input.GetKeyDown(KeyCode.Alpha6))
        {
             SceneManager.LoadScene("video1");
        }
         if(Input.GetKeyDown(KeyCode.Alpha7))
        {
             SceneManager.LoadScene("danca");
        }
    }
}
