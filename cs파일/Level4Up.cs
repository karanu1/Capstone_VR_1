using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4Up : MonoBehaviour
{
    public bool boll_count = false;
    public bool banjuc3_count = false;
    public GameObject circle_banjuc;
    public Vector3 iron_position;
    public GameObject iron_pan;
    public GameObject Imformation_2;
    int count_imfor = 0;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "boll")
        {
            boll_count = true;
        }
        if (other.transform.tag == "banjuc3")
        {
            banjuc3_count = true;
        }
        if((boll_count == true)&&(banjuc3_count == true)&&(count_imfor == 0))
        {
            Imformation_2.SetActive(true);
            count_imfor++;
        }
    }
}
