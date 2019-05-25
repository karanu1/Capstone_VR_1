using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Qize : MonoBehaviour
{
    int[] a = new int[4];
    public int count = 0;
    public GameObject cube; // cube오브젝트
    public int[] Rand() // 랜덤으로 0~3 숫자 뽑기
    {
        int[] RandNum = new int[4];
        for(int i = 0; i < 4; i++) //중복 제거
        {
            RandNum[i] = Random.Range(0, 4);
            for(int j=0; j < i; j++)
            {
                if(RandNum[i] == RandNum[j])
                {
                    i--;
                    break;
                }
            }
        }
        
        return RandNum;
        
    }
    void OnGUI()
    {
        if(count == 0)
        {
            a = Rand(); //a배열에 0,1,2,3랜덤순으로 저장
            count++;
        }

        //   GUI.BUtton(new Rect());
        GUI.TextArea(new Rect(300, 10, 300, 50), "ddddddddddddd");
        GUI.Button(new Rect(300, (a[0] + 1) * 100, 300, 50), "2번");
        GUI.Button(new Rect(300, (a[1] + 1) * 100, 300, 50), "3번");
        GUI.Button(new Rect(300, (a[2] + 1) * 100, 300, 50), "4번");
        if(GUI.Button(new Rect(300, (a[3] + 1) * 100, 300, 50), "1번") == true)
        {
            Destroy(cube); // 큐브객체 파괴

        }


    }
}
