using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkfun : MonoBehaviour
{
    public GameObject sugar;
    public GameObject solt;
    public GameObject banjuc;
    public GameObject east;
    public GameObject egg;
    public GameObject banjuc2;
    public GameObject can;
    public GameObject shortning;
    public GameObject banjuc3;
    public GameObject Imformation;
    public GameObject bunU;
    public GameObject mill;
    public GameObject bread_powder;
    public GameObject mixing;
    public Text[] but_text = new Text[4];
    public Text can_text;
    public Button[] but = new Button[4];
    public int count = 1;
    public bool[] check_sum = new bool[14];


    public bool sugar_count = false;
    public bool bunU_count = false;
    public bool mill_count = false;
    public bool solt_count = false;
    public bool egg_count = false;
    public bool east_count = false;
    public bool shortning_count = false;
    public bool bread_powder_count = false;


    public Vector3[] posi = new Vector3[6];
    public int[] quiz_position = new int[4];

    void Start()
    {
        for(int i=0; i<14; i++)
        {
            check_sum[i] = false;
        }
    }
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
        posi[0] = new Vector3(-140, 0, 0);
        posi[1] = new Vector3(140, 0, 0);
        posi[2] = new Vector3(-140, -60, 0);
        posi[3] = new Vector3(140, -60, 0);
    }
    public void Quiz_mix()
    {
        Wici();
        quiz_position = Rand();
        for (int i = 0; i < 4; i++)
        {
            but[i].transform.localPosition = posi[quiz_position[i]];
        }
        if (count == 1)
        {
            can_text.GetComponent<Text>().text = "이때의 믹싱 단수는??";
            but_text[0].GetComponent<Text>().text = "믹싱 2단";
            but_text[1].GetComponent<Text>().text = "믹싱 1단";
            but_text[2].GetComponent<Text>().text = "믹싱 3단";
            but_text[3].GetComponent<Text>().text = "믹싱 4단";
        }
        if(count == 2)
        {
            can_text.GetComponent<Text>().text = "이때의 믹싱 단수는??";
            but_text[0].GetComponent<Text>().text = "믹싱 2단";
            but_text[1].GetComponent<Text>().text = "믹싱 1단";
            but_text[2].GetComponent<Text>().text = "믹싱 3단";
            but_text[3].GetComponent<Text>().text = "믹싱 4단";
        }
        if(count == 3)
        {
            can_text.GetComponent<Text>().text = "발효실의 온도와 습도는??";
            but_text[0].GetComponent<Text>().text = "온도 : 27 \n 습도 : 32 ";
            but_text[1].GetComponent<Text>().text = "온도 : 28 \n 습도 : 32 ";
            but_text[2].GetComponent<Text>().text = "온도 : 29 \n 습도 : 33";
            but_text[3].GetComponent<Text>().text = "온도 : 30 \n 습도 : 34";
        }
    }
  
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "sugar")
        {
            sugar_count = true;
        }
        if (collision.gameObject.tag == "solt")
        {
            solt_count = true;
        }
        if (collision.gameObject.tag == "bunU")
        {
            bunU_count = true;
        }
        if (collision.gameObject.tag == "mill")
        {
            mill_count = true;
        }
        if (collision.gameObject.tag == "east")
        {
            east_count = true;
        }
        if (collision.gameObject.tag == "egg")
        {
            egg_count = true;
        }
        if (collision.gameObject.tag == "bread_powder")
        {
            bread_powder_count = true;
        }
        if ((collision.gameObject.tag == "shortning") && (count == 2))
        {
            shortning_count = true;
            mixing.SetActive(true);
            count++;
        }
        if (((egg_count == true) || (east_count == true))&&(count == 1)) //2단계
        {
            mixing.SetActive(true);
            count++;
        }
        if (((mill_count == true) || (solt_count == true) || (sugar_count == true) || (bunU_count == true) || (bread_powder_count = true)) && (count == 0)) //1단계
        {
            mixing.SetActive(true);
            count++;
        }

    }
    void check()
    {
        if((mill_count == true) && (solt_count == true) && (sugar_count == true) && (bunU_count == true))
        {
            check_sum[0] = true;
        }
    }
}
