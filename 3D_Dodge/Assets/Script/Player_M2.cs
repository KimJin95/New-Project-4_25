using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

//Useing Horizontal , Vertical 
public class Player_M2 : MonoBehaviour
{
    private Rigidbody PlayerRig;
    public float speed = 5f;
    void Start()
    {
        PlayerRig = GetComponent<Rigidbody>();
    }


    void Update()
    {
        //GetAxis= -1 ~ 1 
        float x_Input = Input.GetAxis("Horizontal");
        float z_Input = Input.GetAxis("Vertical");

        PlayerRig.velocity = new Vector3(x_Input * speed, 0, z_Input * speed);



    }
}
