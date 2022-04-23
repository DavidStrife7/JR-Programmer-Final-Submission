using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFast : BallDefault
{
    // INHERITANCE
    private Transform thisBall;
    private void Start()
    {
        thisBall = GetComponent<Transform>();
    }
    public override void MoveUp() // POLYMORPHISM
    {
        thisBall.position += (Vector3.up * (Time.deltaTime * 2));
    }

    public override void MoveDown() // POLYMORPHISM
    {
        thisBall.position += (Vector3.down * (Time.deltaTime * 2));
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveUp();
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveDown();
        }
    }
}
