using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCC : MonoBehaviour
{
    public GameObject cir_cle;
    public GameObject long_banjuc;
    public GameObject Imformation3;

    public Vector3 cir_cle_posi;
    
    void Start()
    {

    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "banjuc4")
        {
            Instantiate(long_banjuc, new Vector3(84, 4, 56),cir_cle.transform.rotation);
            Destroy(GameObject.FindGameObjectWithTag("banjuc4"), 0f);
            Imformation3.SetActive(true);

        }
    }
}
