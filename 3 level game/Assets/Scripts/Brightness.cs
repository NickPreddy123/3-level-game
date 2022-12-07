using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brightness : MonoBehaviour
{
    public Slider slider;
    public Light flashlight;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        flashlight.intensity = slider.value;
    }
}
