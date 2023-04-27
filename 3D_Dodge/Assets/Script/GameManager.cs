using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

//���ӳ������� �������, ���� ����
//�÷����� hp�� 0�� �Ǿ����� �������
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
                isGameOver = false; //static�̶� �ʱ�ȭ �ʼ�
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    //playerPrefs-> ������Ʈ�� ������ ->HKEY_Current_User->UNITY EDITOR -> �ش�Ǵ� ����Ƽ ���α׷� open
    public void Record_End()
    {
        isGameOver = true;

        float bestTime = PlayerPrefs.GetFloat("BestTime");
        
        //3���� �ڷ��� ���� {int, float, string}

        if (survieTime>bestTime)
        {
            bestTime = survieTime;
            PlayerPrefs.SetFloat("BestTime", bestTime);
            UIManager.recordText.text="BestTime : "+(int)bestTime;
        }
        else UIManager.recordText.text = "BestTime : " + (int)bestTime;
    }
}
