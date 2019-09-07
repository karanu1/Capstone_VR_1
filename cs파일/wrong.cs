using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Col;
public class wrong : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public Color32 m_NormalColor = Color.white;
    public Color32 m_HoverColor = Color.grey;
    public Color32 m_DownColor = Color.white;
    public GameObject Can;
    public GameObject Level4_active;
    public GameObject Level1_banjuc;
    public GameObject Level2_banjuc;
    public GameObject circle_banjuc;
    public GameObject iorn_pan;
    public GameObject bread_in_dish;
    public GameObject pullman;
   // public int count_Level = 1;
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
        if (Collect.count_Level == 6)
        {
            Collect.count_Level++;
            Can.SetActive(false);
            Instantiate(pullman, new Vector3(86, 4, 56), Quaternion.identity);
        }
        if (Collect.count_Level == 5)
        {
            Collect.count_Level++;
            Can.SetActive(false);
            Instantiate(bread_in_dish, new Vector3(86, 4, 56), Quaternion.identity);
        }
        if (Collect.count_Level == 4)
        {
            Collect.count_Level++;
            Can.SetActive(false);
            Destroy(GameObject.FindGameObjectWithTag("banjuc3"), 0f);
            Instantiate(circle_banjuc, new Vector3(84, 4, 56), Quaternion.identity);
        }
        if (Collect.count_Level == 3)
        {
            Collect.count_Level++;
            Can.SetActive(false);
            Level4_active.SetActive(true);
        }
        if (Collect.count_Level == 2)
        {
            Collect.count_Level++;
            Can.SetActive(false);
            Instantiate(Level2_banjuc, new Vector3(77.92f, 0.88f, 45.21f), Quaternion.identity);
        }
        if (Collect.count_Level == 1)
        {
            Collect.count_Level++;
            Can.SetActive(false);
            Instantiate(Level1_banjuc, new Vector3(77.92f, 0.88f, 45.21f), Quaternion.identity);
        }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        print("Click");
        m_Image.color = m_HoverColor;
    }
}

