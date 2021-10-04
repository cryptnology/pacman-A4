using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    float timer = 0.0f;
    float currentIntTimer = 0.0f;
    SpriteRenderer superPellets;

    void Start()
    {
        superPellets = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        timer += Time.deltaTime;
        currentIntTimer = (float)System.Math.Round(timer, 1);

        if (currentIntTimer == 1.0)
        {
            superPellets.enabled = false;
        }
        if (currentIntTimer == 2.0)
        {
            superPellets.enabled = true;
            timer = 0;
        }
    }
}
