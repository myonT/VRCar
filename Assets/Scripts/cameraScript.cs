using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{

    GameObject Mcamera;
    GameObject Vrcamera;

    Quaternion Mcamq;
    Quaternion Vcamq;

    // Use this for initialization
    void Start()
    {
        Mcamera = GameObject.Find("CarWaypointBased");

    }

    // Update is called once per frame
    void Update()
    {
        Mcamera.transform.rotation = Mcamq;
        Vcamq = this.transform.rotation;
        Vcamq = Mcamq;

    }
}
