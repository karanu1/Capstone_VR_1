using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level6_active : rand_quiz
{
    public GameObject canvus6;
    void Start()
    {
        Quiz_mix6();
        canvus6.SetActive(true);
    }

}
