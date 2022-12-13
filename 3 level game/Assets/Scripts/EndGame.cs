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
        Cursor.visible = true;
        Time.timeScale = 0f;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Endgame();
        }
        
        
    }

}
