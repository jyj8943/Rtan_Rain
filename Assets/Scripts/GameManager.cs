using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject rain;
    
    void Start()
    {
        InvokeRepeating("MakeRain", 0f, 1f);
    }
    
    void Update()
    {
        
    }

    public void MakeRain()
    {
        Instantiate(rain);
    }
}
