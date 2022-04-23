using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReverse : BallDefault
{
    private Transform thisBall;
    private void Start()
    {
        thisBall = GetComponent<Transform>();
    }
    public override void MoveUp()
    {
        thisBall.position += (Vector3.up * Time.deltaTime);
    }

    public override void MoveDown()
    {
        thisBall.position += (Vector3.down * Time.deltaTime);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveDown();
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveUp();
        }
    }
}
