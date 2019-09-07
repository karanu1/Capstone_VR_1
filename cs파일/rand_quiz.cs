using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rand_quiz : MonoBehaviour
{
    public GameObject[] canvus = new GameObject[4];
    public Text can_text;
    public Vector3[] posi = new Vector3[4];
    public int[] quiz_position = new int[4];
    public Text[] but_text = new Text[4];
    public int count = 1;
    public int[] Rand() // 랜덤으로 0~3 숫자 뽑기
    {
        int[] RandNum = new int[4];
        for (int i = 0; i < 4; i++) //중복 제거
        {
            RandNum[i] = Random.Range(0, 4);
            for (int j = 0; j < i; j++)
            {
                if (RandNum[i] == RandNum[j])
                {
                    i--;
                    break;
                }
            }
        }

        return RandNum;

    }
    public void Wici()
    {
        posi[0] = new Vector3(318, 187, 0);
        posi[1] = new Vector3(-320, 188, 0);
        posi[2] = new Vector3(319, -88, 0);
        posi[3] = new Vector3(-321, -88, 0);
    }
    public void Quiz_mix1()
    {
        Wici();
        quiz_position = Rand();
        for (int i = 0; i < 4; i++)
        {
            canvus[i].transform.localPosition = posi[quiz_position[i]];
        }
            can_text.GetComponent<Text>().text = "이때의 믹싱 단수는??";
            but_text[0].GetComponent<Text>().text = "믹싱 2단";
            but_text[1].GetComponent<Text>().text = "믹싱 1단";
            but_text[2].GetComponent<Text>().text = "믹싱 3단?";
            but_text[3].GetComponent<Text>().text = "믹싱 4단?";  
    }
    public void Quiz_mix2()
    {
        Wici();
        quiz_position = Rand();
        for (int i = 0; i < 4; i++)
        {
            canvus[i].transform.localPosition = posi[quiz_position[i]];
        }
        can_text.GetComponent<Text>().text = "이때의 믹싱 단수는??";
        but_text[0].GetComponent<Text>().text = "믹싱 2단";
        but_text[1].GetComponent<Text>().text = "믹싱 1단";
        but_text[2].GetComponent<Text>().text = "믹싱 3단??";
        but_text[3].GetComponent<Text>().text = "믹싱 4단??";
    }
    public void Quiz_mix3()
    {
        Wici();
        quiz_position = Rand();
        for (int i = 0; i < 4; i++)
        {
            canvus[i].transform.localPosition = posi[quiz_position[i]];
        }
        can_text.GetComponent<Text>().text = "발효실의 온도와 습도는??";
        but_text[0].GetComponent<Text>().text = "온도 : 27도 \n 습도 : 32도 ";
        but_text[1].GetComponent<Text>().text = "온도 : 28도 \n 습도 : 32도 ";
        but_text[2].GetComponent<Text>().text = "온도 : 29도 \n 습도 : 33도";
        but_text[3].GetComponent<Text>().text = "온도 : 30도 \n 습도 : 34도";
    }
    public void Quiz_mix4()
    {
        Wici();
        quiz_position = Rand();
        for (int i = 0; i < 4; i++)
        {
            canvus[i].transform.localPosition = posi[quiz_position[i]];
        }
        can_text.GetComponent<Text>().text = "둥글리기를 위해 반죽을 분할해야하는데 이때 분할한 반죽의 무게는?";
        but_text[0].GetComponent<Text>().text = "250g";
        but_text[1].GetComponent<Text>().text = "200g";
        but_text[2].GetComponent<Text>().text = "150g";
        but_text[3].GetComponent<Text>().text = "300g";
    }
    public void Quiz_mix5()
    {
        Wici();
        quiz_position = Rand();
        for (int i = 0; i < 4; i++)
        {
            canvus[i].transform.localPosition = posi[quiz_position[i]];
        }
        can_text.GetComponent<Text>().text = "2차 발효시 온도와 습도는?";
        but_text[0].GetComponent<Text>().text = "온도 : 32도 \n 습도 : 35~38도 ";
        but_text[1].GetComponent<Text>().text = "온도 : 31도 \n 습도 : 31~35도 ";
        but_text[2].GetComponent<Text>().text = "온도 : 30도 \n 습도 : 29~31도";
        but_text[3].GetComponent<Text>().text = "온도 : 29도 \n 습도 : 38~40도";
    }
    public void Quiz_mix6()
    {
        Wici();
        quiz_position = Rand();
        for (int i = 0; i < 4; i++)
        {
            canvus[i].transform.localPosition = posi[quiz_position[i]];
        }
        can_text.GetComponent<Text>().text = "이때 오븐위 윗불과 아랫불의 온도는?";
        but_text[0].GetComponent<Text>().text = "윗불 : 170도 \n 아랫불 : 170도 ";
        but_text[1].GetComponent<Text>().text = "윗불 : 180도 \n 아랫불 : 180도 ";
        but_text[2].GetComponent<Text>().text = "윗불 : 160도 \n 아랫불 : 160도";
        but_text[3].GetComponent<Text>().text = "윗불 : 150도 \n 아랫불 : 150도";
    }

}
