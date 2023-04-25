using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//throgh the Rgidboy make this Object(attached this script) move
public class Player_M : MonoBehaviour
{
    private Rigidbody PlayerRig;

    public float speed;
    void Start()
    {
        PlayerRig= GetComponent<Rigidbody>();   
    }

    
    void Update()
    {

        //z-> + front - back x-> + right - left y-> + up - down
        if (Input.GetKey(KeyCode.UpArrow))
        {
            PlayerRig.AddForce(new Vector3(0, 0, speed));
            //PlayerRig.velocity = new Vector3(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            PlayerRig.AddForce(new Vector3(0, 0, -speed));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            PlayerRig.AddForce(new Vector3(speed, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            PlayerRig.AddForce(new Vector3(-speed, 0, 0));
        }
    }
}
