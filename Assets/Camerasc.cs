using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerasc : MonoBehaviour
{
    public float direction;
    public GameObject Camera;

    void Start()
    {
        direction = 0;
        Camera = GameObject.Find("Camera");
    }

    void Update()
    {
        //if (Input.GetKey("right"))
        //{
        //    direction += 0.5f;
        //    transform.Rotate(0, direction, 0);
        //    Camera.GetComponent<NomalInput>().RightRotate();
        //}
        //
        //if (Input.GetKeyUp("right"))
        //{
        //    direction = 0;
        //}
        //
        //if (Input.GetKey("left"))
        //{
        //    direction -= 0.5f;
        //    transform.Rotate(0, direction, 0);
        //    Camera.GetComponent<NomalInput>().LeftRotate();
        //}
        //
        //if (Input.GetKeyUp("left"))
        //{
        //    direction = 0;
        //}
    }
}