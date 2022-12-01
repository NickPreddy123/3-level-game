using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Barrelcollision : MonoBehaviour
{
    public GameObject Button;
    public GameObject Button2;
    public GameObject Player;
    public GameObject DeathCam;
    public GameObject Deathtext;

    private void Start()
    {
       
    }

    void Disappear()
    {
        Button.SetActive(false);
        
    }

    void RestartGame()
    {
       
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Button.SetActive(true);
            Player.SetActive(false);
            DeathCam.SetActive(true);
            Button2.SetActive(true);
            Deathtext.SetActive(true);
            
        }
    }

    
}
