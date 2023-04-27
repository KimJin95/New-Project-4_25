using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text playerHp_Text;
    public PlayerHP playerHp;
    public Text recordText;
    public Text surviveTime_Text;

    void Start()
    {
        //PlayerPrefs.SetFloat("BestTime", 0f); 
    }

 
    void Update()
    {
        if (playerHp.hp>=0)
        {
            playerHp_Text.text = "HP: " + playerHp.hp;
            
        }
    }
}
