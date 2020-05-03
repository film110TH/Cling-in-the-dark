using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    private Animator anime;

    private void Start()
    {
        anime = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anime.SetBool("WalkA", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anime.SetBool("WalkA", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anime.SetBool("WalkD", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anime.SetBool("WalkD", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            anime.SetBool("Run", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            anime.SetBool("Run", false);
        }
    }
}
