using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

//게임내에서의 점수기록, 게임 종료
//플레잉의 hp가 0이 되었을때 점수기록
public class GameManager : MonoBehaviour
{
    public static bool isGameOver = false;

    private float survieTime = 0f;

    public UIManager UIManager;

    void Start()
    {

    }


    void Update()
    {
        if (!isGameOver)
        {
            survieTime += Time.deltaTime;
            UIManager.surviveTime_Text.text = "Time : " + (int)survieTime;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                isGameOver = false; //static이라 초기화 필수
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    //playerPrefs-> 레지스트리 편집기 ->HKEY_Current_User->UNITY EDITOR -> 해당되는 유니티 프로그램 open
    public void Record_End()
    {
        isGameOver = true;

        float bestTime = PlayerPrefs.GetFloat("BestTime");
        
        //3가지 자료형 저장 {int, float, string}

        if (survieTime>bestTime)
        {
            bestTime = survieTime;
            PlayerPrefs.SetFloat("BestTime", bestTime);
            UIManager.recordText.text="BestTime : "+(int)bestTime;
        }
        else UIManager.recordText.text = "BestTime : " + (int)bestTime;
    }
}
