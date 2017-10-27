using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    // Use this for initialization
    private void Start()
    {
        GetComponent<WheelCollider>().motorTorque = 100 * 0.05f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
