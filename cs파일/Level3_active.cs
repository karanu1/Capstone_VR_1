using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3_active : rand_quiz
{
    public GameObject canvus3;
    public void Strat()
    {
        Quiz_mix3();
        canvus3.SetActive(true);
    }

}
