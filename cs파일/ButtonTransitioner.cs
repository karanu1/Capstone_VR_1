using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonTransitioner : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public Color32 m_NormalColor = Color.white;
    public Color32 m_HoverColor = Color.grey;
    public Color32 m_DownColor = Color.white;
    public GameObject Level_1;
    public GameObject Level_2;
    public GameObject Imformation;
    public GameObject Level2_banjuc;
    public GameObject Level3_banjuc;
    public GameObject mix_can;

    public int count_Level = 1;

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
        m_Image.color = m_NormalColor;
        if(count_Level == 3)
        {
            Destroy(GameObject.FindGameObjectWithTag("banjuc2"), 0f);
            Destroy(GameObject.FindGameObjectWithTag("shortning"), 0f);
            Instantiate(Level3_banjuc, new Vector3(77.92f, 0.88f, 45.21f), Quaternion.identity);
            Imformation.SetActive(true);
            mix_can.SetActive(false);
            count_Level++;
        }
        if(count_Level == 2)
        {
            Level_2.SetActive(true);
            mix_can.SetActive(false);
            count_Level++;
        }

        if (count_Level == 1)
        {
            Level_1.SetActive(true);
            mix_can.SetActive(false);
            count_Level++;
        }
 
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        print("Click");
        m_Image.color = m_HoverColor;
    }
}
