using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bread_dish : MonoBehaviour
{
    // Start is called before the first frame update\
    public GameObject Level_5;
    public GameObject breadist;
    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "sphere_bread")
        {
            breadist.SetActive(false);
            Destroy(GameObject.FindGameObjectWithTag("sphere_bread"), 0f);
            Level_5.SetActive(true);
        }
    }
}
