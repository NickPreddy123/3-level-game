using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpOut : MonoBehaviour
{

    public GameObject jump;

    public void Start()
    {
        jump.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {

            jump.SetActive(true);

        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            jump.SetActive(true);

        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            jump.SetActive(false);

        }
    }
}
