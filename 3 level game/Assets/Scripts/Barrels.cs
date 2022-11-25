using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrels : MonoBehaviour
{
    public GameObject Barrel;
    public Vector3 origin = Vector3.zero;
    public float interval = 5;
    float timer;
    public float radius = 10;


    void SpawnObject()
    {
        Vector3 randomPosition = origin + Random.insideUnitSphere * radius;
        Instantiate(Barrel, randomPosition, Random.rotation);
        
        
    }
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            SpawnObject();

            timer -= interval;
        }

        
    }
}
