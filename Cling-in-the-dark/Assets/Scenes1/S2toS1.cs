using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S2toS1 : MonoBehaviour
{
    private int prev;
    void Start()
    {
        prev = SceneManager.GetActiveScene().buildIndex - 1;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
                SceneManager.LoadScene(prev);
           
        }
    }
}
