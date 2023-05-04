using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Controller : MonoBehaviour
{
    float speed = 0.05f;
    int dir = 1;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    void Update()
    {
        float x = speed * dir;
        
        //if(transform.position.x > 3)
        //{
        //    dir = -1;
        //}
        //if(transform.position.x < -3)
        //{
        //    dir = 1;
        //}
        //print(x);
        transform.position += new Vector3(x, 0, 0);        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Tri " + other.name);
        if(other.name == "Right_Collider")
        {
            dir = -1;
        }
        else if(other.name == "Left_Collider")
        {
            dir = 1;
        }
    }
}
