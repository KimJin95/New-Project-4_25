using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHP : MonoBehaviour
{
    //ParticleSystem -> ����Ƽ ȿ�� 
    public ParticleSystem hitEffect;

    public float hp = 100f;


    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            hp -= 5f;
            hitEffect.Play();

            Destroy(collision.gameObject);
        }
    }

    void Update()
    {

    }
}
