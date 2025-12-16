using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Opdracht2 : MonoBehaviour
{

    void Start()
    {
        float randomHeight = Random.Range(1f, 5f);


        transform.localScale = new UnityEngine.Vector3(1f, randomHeight, 1f);
    }

    
    void Update()
    {
        
    }
}
