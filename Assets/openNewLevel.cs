using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openNewLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
	    Debug.Log("here " + this.name);
	    if( this.name == "ChestLevel2" )
        {
            SceneManager.LoadScene("CTF TEMP 2");
        }
        else
        {
	        SceneManager.LoadScene("CTF TEMP");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("here " + other.name);
    }

    private void OnCollisionEnter()
    {

    }
}
