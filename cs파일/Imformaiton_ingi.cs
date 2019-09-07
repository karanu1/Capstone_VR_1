using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Imformaiton_ingi : rand_quiz, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public Color32 m_NormalColor = Color.white;
    public Color32 m_HoverColor = Color.grey;
    public Color32 m_DownColor = Color.white;

    public GameObject jp;
    public Sprite[] jpg = new Sprite[4];
    public Text text_sul;
    public Text button_text;
    public GameObject Imformation_2;
    public GameObject Level_3;
    public GameObject canvus3;
    public GameObject sphere_banjuc;
    public GameObject long_banjuc;
    public GameObject bread_dish;
    public int next_count = 0;
    private Image m_Image = null;

    private void Awake()
    {
        m_Image = GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        m_Image.color = m_HoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        m_Image.color = m_NormalColor;
    }
    public void OnPointerDown(PointerEventData eventData)
    {

        m_Image.color = m_DownColor;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
       if(next_count == 4)
        {
            Imformation_2.SetActive(false);
            Instantiate(sphere_banjuc, new Vector3(84, 4, 56), long_banjuc.transform.rotation);
            bread_dish.SetActive(true);
            Destroy(GameObject.FindGameObjectWithTag("long_banjuc"), 0f);
        }
        if (next_count == 3)
        {
            jp.GetComponent<Image>().sprite = jpg[3];
            text_sul.GetComponent<Text>().text = "이쁜 반죽 완성!";
            button_text.GetComponent<Text>().text = "확인";
            next_count++;


        }
        if (next_count == 2)
        {
            jp.GetComponent<Image>().sprite = jpg[2];
            text_sul.GetComponent<Text>().text = "돌돌돌 말아주세요";
            next_count++;

        }
        if (next_count == 1)
        {
            jp.GetComponent<Image>().sprite = jpg[1];
            text_sul.GetComponent<Text>().text = "끝부분을 세모낳게 접어주세요";
            next_count++;
             
        }
        if (next_count == 0)
        {
            Quiz_mix3();
            canvus3.SetActive(true);
            Imformation_2.SetActive(false);
            jp.GetComponent<Image>().sprite = jpg[0];
            text_sul.GetComponent<Text>().text = "3단접기를 합니다.";
            button_text.GetComponent<Text>().text = "다음";
            next_count++;
        }
            
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        print("Click");
        m_Image.color = m_HoverColor;
    }
}
