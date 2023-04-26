using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Move forward
public class Bullet : MonoBehaviour
{
   

    private Rigidbody bulletRig;

    public float speed = 8f;
    public float DestoryTime = 3f;

    void Start()
    {
        Destroy(gameObject, DestoryTime);

        bulletRig = GetComponent<Rigidbody>();

        bulletRig.velocity = this.transform.forward * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
      //  Destroy(gameObject);
    }

}
