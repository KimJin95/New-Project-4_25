using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//make obj Rotate
public class Rotator : MonoBehaviour
{
    public float rotateSpeed = 30f;
 

    void Update()
    {
        this.transform.Rotate(0,rotateSpeed*Time.deltaTime,0);
    }
}
