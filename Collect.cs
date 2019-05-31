using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public bool [] collect = new bool[11];
    public int Level = 0;
    public GameObject Canvus;
    private void Start()
    {
      for(int i=0; i<11; i++)
        {
            collect[i] = false;
        }
    }

    public void Collectt()
    {
        collect[Level] = true;
        Canvus.SetActive(false);
    }
    public void Tle()
    {
        collect[Level] = false;
        Canvus.SetActive(false);
    }
}
