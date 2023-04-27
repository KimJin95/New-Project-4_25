using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHP : MonoBehaviour
{
    //ParticleSystem -> 유니티 효과 
    public ParticleSystem hitEffect;

    public float hp = 100f;

    public GameManager gameManager;

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

            if (hp<=0)
            {
                if (!GameManager.isGameOver)
                {
                    GameManager.isGameOver = true;  
                    gameManager.Record_End();
                }

            }
        }
    }

    void Update()
    {

    }
}
