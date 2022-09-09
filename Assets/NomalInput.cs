using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomalInput : MonoBehaviour
{
    public GameObject obj ;
    public GameObject lazer;
    Transform item;
    Transform a;
    public float speed = 4.0f;
   //Start is called before the first frame update
   void Start()
    {
        a = obj.gameObject.transform;

        item = lazer.gameObject.transform;
        item.gameObject.SetActive(false);
        
    }
   //Update is called once per frame
void Update()
   {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            item.gameObject.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            item.gameObject.SetActive(false);
        }

        
        

        if (Input.GetKey(KeyCode.UpArrow)){
            
            Vector3 velocity = a.rotation * new Vector3(0, 0, speed);
            gameObject.transform.position += velocity * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            Vector3 velocity = a.rotation * new Vector3(0, 0, -speed);
            gameObject.transform.position += velocity * Time.deltaTime;

        }   
        if(Input.GetKey(KeyCode.RightArrow)){
            Vector3 velocity = a.rotation * new Vector3(speed,0,0);
            gameObject.transform.position += velocity * Time.deltaTime;

        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            Vector3 velocity = a.rotation * new Vector3(-speed,0,0);
            gameObject.transform.position += velocity * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.V))
        {
            Vector3 velocity = new Vector3(0, speed,0);
            gameObject.transform.position += velocity * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.B))
        {
            Vector3 velocity = new Vector3(0, -speed, 0);
            gameObject.transform.position += velocity * Time.deltaTime;
        }
        //this.transform.rotation = Quaternion.Euler(0.0f,a ,0.0f);
        //Debug.Log(this.transform.rotation);
    }
}
