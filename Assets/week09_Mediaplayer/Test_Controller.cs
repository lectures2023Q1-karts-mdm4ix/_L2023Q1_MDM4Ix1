using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Controller : MonoBehaviour
{
    public GameObject GO1;
    public float x;

    void Start()
    {

    }

    private void Update()
    {
        //print(GO1.transform.position);
        GO1.transform.position += new Vector3(0.01f, 0, 0);
        //print(GO1.GetComponent<Cube_Controller>().myInt);
    }
}
