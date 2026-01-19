using NUnit.Framework.Internal;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.WindowsMR.Input;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float movespeed = 1.5f;
    private float outofbounds = -9f;
    private float minY = -0.53f;
    private float maxY = 1.49f;
    

    private void Awake()
    {
        float randYaxis = UnityEngine.Random.Range(minY, maxY);
        transform.position= new Vector3(transform.position.x, randYaxis, transform.position.z);
    }

    void Update()
    {
        
        transform.position = transform.position + (Vector3.left * movespeed * Time.deltaTime);
        
        if(transform.position.x <= outofbounds)
        {
            SelfDestroy();
        }
    }


    private void SelfDestroy()
    {
        Destroy(gameObject);
    }
}
