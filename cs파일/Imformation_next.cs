using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Imformation_next : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public Color32 m_NormalColor = Color.white;
    public Color32 m_HoverColor = Color.grey;
    public Color32 m_DownColor = Color.white;

    public GameObject jp;
    public Sprite jpg;
    public Text Imfor_text;
    public Text button_text;
    public GameObject Imformaition;
    public GameObject Imformation_2;
    public GameObject Level_3;

    public int end_count = 0;
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
        if(end_count == 2)
        {
            Imformation_2.SetActive(false);
            Level_3.SetActive(true);

        }
        
        if (end_count == 1)
        {
            Imformaition.SetActive(false);
            end_count++;
        }
        if (end_count == 0)
        {
            jp.GetComponent<Image>().sprite = jpg;
            Imfor_text.GetComponent<Text>().text = "손가락이 비칠정도로 얇게 잘 늘어나면 잘 된 반죽";
            button_text.GetComponent<Text>().text = "확인";
            end_count++;
        }

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        print("Click");
        m_Image.color = m_HoverColor;
    }
}
