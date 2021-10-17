using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudent : MonoBehaviour
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
