using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class animatica : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(irparacena());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            SceneManager.LoadScene("casino");
        }
        
    }
    IEnumerator irparacena() {
        yield return new WaitForSeconds(160f);
        SceneManager.LoadScene("casino");
    }
}
