using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    
    public GameObject Text;

    private void Start()
    {
        Disappear();

    }
    void Disappear()
    {
        Text.SetActive(false);
    }





    void Endgame()
    {
        Instantiate(Text, transform.position, transform.rotation);
        Text.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Endgame();
        }
        
        
    }

}
