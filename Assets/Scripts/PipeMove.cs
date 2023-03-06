using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField]
    float PipeSpeed = 0.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * PipeSpeed * Time.deltaTime; // Vector3.left = (-1, 0, 0)
    }
} 
