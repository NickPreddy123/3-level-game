using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorScript : MonoBehaviour
{
    public Transform DoorLeft;
    public Transform DoorRight;
    public float OpenAmount;
    public float CloseAmount;
    
    void MoveObject() //If you are facing X+ use positive numbers for Open And close amount if X- use negative numbers
    {
        DoorLeft.transform.position = DoorLeft.transform.position + new Vector3(OpenAmount * Time.deltaTime, 0f, 0f);

        DoorRight.transform.position = DoorRight.transform.position + new Vector3(OpenAmount * -Time.deltaTime, 0f, 0f);
    }

    void StopObject()
    {
        
        DoorLeft.transform.position = DoorLeft.transform.position + new Vector3(CloseAmount * -Time.deltaTime, 0f, 0f);

        DoorRight.transform.position = DoorRight.transform.position + new Vector3(CloseAmount * Time.deltaTime, 0f, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            MoveObject();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StopObject();
        }
    }
}
