using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brightness : MonoBehaviour
{
    public Slider slider;
    public Light sceneLight;
    
    void Start()
    {
       
    }


    void Update()
    {
        sceneLight.intensity = slider.value;

      
       
    }

    
}
