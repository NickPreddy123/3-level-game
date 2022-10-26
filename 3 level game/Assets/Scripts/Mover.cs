using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    // Update is called once per frame
    void Update()
    {

        
    }
    void MoveObject()
    {
        transform.position = transform.position + new Vector3(speed * Time.deltaTime,0f, 0f);
    }

    void RotateObject() 
    {
       
        
            transform.Rotate(new Vector3(speed * Time.deltaTime, 0f, 0f));
        
       
    }
    void StopObject()
    {
        transform.Rotate(new Vector3(0f, 0f, 0f));

    }

    private void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.tag == "Player")
        {
             
            Debug.Log("Object Entered the Trigger");
          
        }
       
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            MoveObject();
            Debug.Log("Object is in the Trigger");
            
        }

       
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            Debug.Log("Object has left the trigger");

        }
        

    }
    





}


