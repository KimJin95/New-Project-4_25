using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefabs;

    public float createBullet_Min = 0.5f;
    public float createBullet_Max = 3f;

    private Transform target;
    private float createBullet_Time;
    private float attackTime = 0f;

    public Transform pivot;

    void Start()
    {
        createBullet_Time = Random.Range(createBullet_Min, createBullet_Max);
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }


    void Update()
    {
        attackTime += Time.deltaTime;

        

        if (attackTime >= createBullet_Time)
        {
          
            attackTime = 0f;

            //instantiate(object,position,rotation)
            GameObject bullet = Instantiate(bulletPrefabs,pivot.position,this.transform.rotation);

            bullet.transform.LookAt(target); //LookAt(transform) : (위치)를 바라본다

            //총알 생성시간을 다시 랜덤값으로 부여
            createBullet_Time = Random.Range(createBullet_Min, createBullet_Max);
        }
    }
}
