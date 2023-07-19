using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float rotationSpeed = 0.3f;


    void Update()
    {
        float rotation = 360 * rotationSpeed * Time.deltaTime;
        
        transform.Rotate(rotation, rotation, rotation);
    }
}