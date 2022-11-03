using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LadderScript1 : MonoBehaviour
{
    public Transform chController;
    bool inside = false;
    public float speedUpDown = 3.2f;
    public SimplePlayerController TPSInput;
    void Start()
    {
        TPSInput = GetComponent<SimplePlayerController>();
        inside = false;
    }
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Ladder")
        {
            TPSInput.enabled = false;
            inside = !inside;
        }
        

    }
    private void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "Ladder")
        {
            TPSInput.enabled = true;
            inside = !inside;
        }
    }
     void Update()
    {
        if(inside == true && Input.GetKey("w"))
        {
            chController.transform.position += Vector3.up / speedUpDown / Time.deltaTime;
                
        }
        if(inside == true && Input.GetKey("s"))
        {
            chController.transform.position += Vector3.down / speedUpDown / Time.deltaTime;
            
        }
    }
}
