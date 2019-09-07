using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2_active : rand_quiz
{
    public GameObject canvus2;
    public GameObject Level1_banjuc;
    public GameObject Level2_egg;
    public GameObject Level2_east;



    void Start()
    {
        Destroy(Level2_egg);
        Destroy(Level2_east);
        Destroy(GameObject.FindGameObjectWithTag("banjuc"), 0f);
        Quiz_mix2();
        canvus2.SetActive(true);
    }
}
