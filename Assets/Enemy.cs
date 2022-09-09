using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject body;
    public float speed = 5.0f;
    private Vector3 pos;
    void Start()
    {
        transform.LookAt(body.transform);
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector3 = body.transform.position - this.transform.position;
        Quaternion quaternion = Quaternion.LookRotation(vector3, Vector3.up);
        this.transform.rotation = quaternion;
        Transform my = this.transform;
        my.Rotate(90.0f, 0, 0);
        Vector3 velocity =   new Vector3(speed,0,0);
        transform.position = new Vector3(pos.x + Mathf.Sin(Time.time) * 5, pos.y, pos.z);
    }
}
