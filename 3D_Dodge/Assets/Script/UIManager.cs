using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text playerHp_Text;
    public PlayerHP playerHp;

    void Start()
    {
        
    }

 
    void Update()
    {
        if (playerHp.hp>=0)
        {
            playerHp_Text.text = "HP: " + playerHp.hp;
        }
    }
}
