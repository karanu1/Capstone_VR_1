using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour
{

    public GameObject long_banjuc;
    public GameObject circle_banjuc;

    public Vector3 circle_banjuc_posi;
    public void OnCollisionEnter(Collision other)
    {
        circle_banjuc.transform.position = circle_banjuc_posi;
        if (other.transform.tag == "circle_banjuc")
        {
            Destroy(GameObject.FindGameObjectWithTag("banjuc4"), 0f);
            Instantiate(long_banjuc, circle_banjuc_posi, Quaternion.identity);
        }
    }
}
