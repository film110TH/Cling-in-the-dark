using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] float speed;
    float rotate = 0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed, 0f, 0f);
            if (rotate != -90f)
            {
                transform.rotation = Quaternion.Euler(0f, -90f, 0f);
                rotate = -90;

            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0f, 0f);
            if (rotate != 90f)
            {
                transform.rotation = Quaternion.Euler(0f, 90f, 0f);
                rotate = 90;

            }
        }
        if (Input.GetKey(KeyCode.S))
        {

            if (rotate != 180f)
            {
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                rotate = 180;

            }
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed + 0.02f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed - 0.02f;
        }
    }
}
