using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runsc : MonoBehaviour
{

    public float speed = 1000;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime;

    }
}
