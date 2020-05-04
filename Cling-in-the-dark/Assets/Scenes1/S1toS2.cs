﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S1toS2 : MonoBehaviour
{
    private int next;
    void Start()
    {
        next = SceneManager.GetActiveScene().buildIndex + 1;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(next);
        }
    }
}
