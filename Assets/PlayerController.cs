using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;
    float xk = 0;

    float gyroScale = 2.0f;
    Quaternion start_gyro;
    Quaternion gyro;

    float speed = 5.0f;

    // Use this for initialization
    void Start()

    {
        Input.gyro.enabled = true;
        //start_gyro = StartCameraController.ini_gyro;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Input.gyro.enabled = true;
        //if (Input.gyro.enabled)
        //{
        //    gyro = Input.gyro.attitude;
        //    //gyro = Quaternion.Euler(90, 0, 0) * (new Quaternion(-gyro.x,-gyro.y, gyro.z, gyro.w));
        //    this.transform.localRotation = gyro;
        //    //最初に見ていた向きとゲームの進行方向を合わせる
        //    this.transform.localRotation = Quaternion.Euler(0, -start_gyro.y, 0);
        //}

        //var dir = Vector3.zero;
        //dir.x = Input.acceleration.x;
        //dir.y = Input.acceleration.y;

        //if (dir.sqrMagnitude > 1)
        //{
        //    dir.Normalize();
        //}

        //dir *= Time.deltaTime;

        //transform.Translate(dir * speed);
    }
}

//void FixedUpdate()
//{
//    xk = Input.gyro.attitude.eulerAngles.x;
//    Debug.Log(xk);

//    //if (xk > 180)
//    //{
//    //    xk -= 360f;
//    //}

//    if (xk < 0f)
//    {
//        xk = xk * -1f;
//    }
//    rb.AddForce(new Vector3(xk * 0.1f, 0, 0));
//}

