using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level5_active : rand_quiz
{
    // Start is called before the first frame update
    public GameObject canvus5;
    void Start()
    {
        Quiz_mix5();
        canvus5.SetActive(true);
    }


}
