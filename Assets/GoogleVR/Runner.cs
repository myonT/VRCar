using UnityEngine;
using System.Collections;

public class Runner : MonoBehaviour
{
    Quaternion gyro;
    bool goal = false;
    public float Speed = 0.3f;
    private GameObject saki;
    Vector3 thispos;
    Vector3 sakipos;

    private void Start()
    {
        saki = GameObject.Find("saki");

    }

    void Update()
    {

        sakipos = saki.transform.position;
        thispos = this.transform.position;

        //float dis = Vector3.Distance(sakipos, thispos);

        transform.position = Vector3.Lerp(thispos, sakipos, 2f);

        //this.transform.position += Vector3(dis);


        //    if (goal == false)
        //    {



        //        Input.gyro.enabled = true;
        //        if (Input.gyro.enabled)
        //        {
        //            //Quaternion gyro = Input.gyro.attitude;
        //            //Quaternion action_gyro = Quaternion.Euler(90, 0, 0) * (new Quaternion(-gyro.x, -gyro.y, gyro.z, gyro.w));

        //        }

        //        var dir = Vector3.zero;
        //        dir.x = Input.acceleration.x;
        //        dir.y = Input.acceleration.y;

        //        if (dir.sqrMagnitude > 1)
        //        {
        //            dir.Normalize();
        //        }

        //        dir *= Time.deltaTime;

        //        //transform.Translate();
        //        Debug.Log(dir.x);
        //        //transform.rotation = new Quaternion(0, dir.y * 1000, 0, 0);
        //    }
        //    else
        //    {

        //        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        //    }
        //}

    }
}