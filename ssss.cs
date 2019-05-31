using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ssss : MonoBehaviour
{
    public GameObject sugar;
    public GameObject garu;
    public GameObject solt;
    public GameObject banjuc;
    public GameObject east;
    public GameObject egg;
    public GameObject banjuc2;
    public GameObject can;
    public Button[] but = new Button[4];
    

    public bool sugar_count = false;
    public bool garu_count = false;
    public bool solt_count = false;
    public bool egg_count = false;
    public bool east_count = false;

    public int count = 0;

    public Vector3[] posi = new Vector3[5];
    public int[] quiz_position = new int[4];
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

        but[0].transform.localPosition = posi[quiz_position[0]];
        but[1].transform.localPosition = posi[quiz_position[1]];
        but[2].transform.localPosition = posi[quiz_position[2]];
        but[3].transform.localPosition = posi[quiz_position[3]];
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
        if (collision.gameObject.tag == "garu")
        {
            garu_count = true;
        }
        if(collision.gameObject.tag == "east")
        {
            east_count = true;
        }
        if (collision.gameObject.tag == "egg")
        {
            egg_count = true;
        }
        if ((garu_count == true)&& (solt_count == true)&&(sugar_count == true)&&(count == 0))
        {

            Instantiate(banjuc,new Vector3(77.92f,0.88f,45.21f), Quaternion.identity);
            Destroy(sugar);
            Destroy(solt);  
            Destroy(garu);
            count++;
            Quiz_mix();
            can.SetActive(true);
        }
        if ((egg_count == true) && (east_count == true)&&(count == 1))
        {
            Destroy(GameObject.FindGameObjectWithTag("banjuc"), 0f);
            Instantiate(banjuc2, new Vector3(77.92f, 1.0f, 45.21f), Quaternion.identity);
            Destroy(egg);
            Destroy(east);
            count++;
        }
    }
}
