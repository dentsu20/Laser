using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
    //    
    //}
    //
    //
    //// Update is called once per frame
    //void Update()
    //{
    //
    //    Debug.Log(Input.GetAxis("Horizontal"));
    //
    //    if(Input.GetKey(KeyCode.Space)) {
    //        this.transform.Translate (0.0f, 0.0f,0.1f);
    //        Debug.Log("up");
    //    }
    //    if (Input.GetKey ("down")) {
    //        this.transform.Translate (0.0f, 0.0f, -0.1f);
    //    }
    //    if(Input.GetKey(KeyCode.Space)){
    //        transform.Translate(0, Time.deltaTime, 0);
    //    }
    //
    //
    //}

    [SerializeField] float speed;
    [SerializeField] float rotateSpeed;

    Rigidbody playerRb;

    float axisH, axisV;
    bool boost;
    bool rotatePermit;

    Quaternion direction;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        axisH = Input.GetAxis("Horizontal");
        axisV = Input.GetAxis("Vertical");

        boost = Input.GetKey(KeyCode.Space);

        if (axisH != 0 || axisV != 0)
        {
            rotatePermit = true;
        }
    }

    void FixedUpdate()
    {
        if (rotatePermit)
        {
            rotatePermit = false;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x - rotateSpeed * axisV, transform.eulerAngles.y + rotateSpeed * axisH, 0);
        }
        if (boost)
        {
            direction = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, 0);

            playerRb.velocity = direction * Vector3.forward * speed * Time.deltaTime * 100;
        }
        else
        {
            playerRb.velocity = Vector3.zero;
        }
    }
}
