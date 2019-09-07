using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1_active : rand_quiz
{
    public GameObject canvus1;
    public GameObject Level1_solt;
    public GameObject Level1_bunU;
    public GameObject Level1_sugar;
    public GameObject Level1_mill;
    public GameObject Level1_bread_powder;


    void Start()
    {
        Destroy(Level1_solt);
        Destroy(Level1_bunU);
        Destroy(Level1_sugar);
        Destroy(Level1_mill);
        Destroy(Level1_bread_powder);
        Quiz_mix1();
        canvus1.SetActive(true);
    }

    // Update is called once per frame
   
}
