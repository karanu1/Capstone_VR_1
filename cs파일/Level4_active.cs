using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4_active : rand_quiz
{
    public GameObject canvus4;
    void Start()
    {
        Quiz_mix4();
        canvus4.SetActive(true);
    }
}
