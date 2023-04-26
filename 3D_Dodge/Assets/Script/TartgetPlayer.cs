using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TartgetPlayer : MonoBehaviour
{
   public GameObject player;
    void Start()
    {
        
    }

   
    void Update()
    {
        this.transform.LookAt(player.transform);
    }
}
