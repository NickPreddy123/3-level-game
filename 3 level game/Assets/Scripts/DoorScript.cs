using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorScript : MonoBehaviour
{
    public GameObject Door;
    
   

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Door.GetComponent<Animation>().Play("Left Door Open");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Door.GetComponent<Animation>().Play("Left Door Close");
        }
    }
}
