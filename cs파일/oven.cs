using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oven : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Level_6;
    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "bread_in_dish")
        {
            Level_6.SetActive(true);
        }
    }
}
