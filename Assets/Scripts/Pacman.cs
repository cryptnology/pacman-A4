using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman : MonoBehaviour
{
    public float speed = 4.0f;

    float timer = 0.0f;
    int currentIntTimer = 0;

    private Vector2 direction = Vector2.zero;

    void Start()
    {

    }

    void Update()
    {
        //CheckInput();

        timer += Time.deltaTime;
        currentIntTimer = (int)timer;


        if (currentIntTimer > 0 && currentIntTimer < 2)
        {
            direction = Vector2.left;
        }
        if (currentIntTimer == 1)
        {
            direction = Vector2.up;
        }
        if (currentIntTimer == 2)
        {
            direction = Vector2.right;

        }
        if (currentIntTimer == 3)
        {
            direction = Vector2.down;
        }
        if (currentIntTimer == 4)
        {
            direction = Vector2.left;
            timer = 0;
        }

        Move();
        CheckOrientation();
    }

    void Move()
    {
        transform.localPosition += (Vector3)(direction * speed) * Time.deltaTime;
    }

    void CheckOrientation()
    {
        if (direction == Vector2.up)
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.localRotation = Quaternion.Euler(0, 0, 90);
        }
        else if (direction == Vector2.down)
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.localRotation = Quaternion.Euler(0, 0, -90);
        }
        else if (direction == Vector2.left)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (direction == Vector2.right)
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
