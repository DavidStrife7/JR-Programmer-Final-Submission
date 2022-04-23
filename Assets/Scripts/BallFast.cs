using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFast : BallDefault
{
    private Transform thisBall;
    private void Start()
    {
        thisBall = GetComponent<Transform>();
    }
    public override void MoveUp()
    {
        thisBall.position += (Vector3.up * (Time.deltaTime * 2));
    }

    public override void MoveDown()
    {
        thisBall.position += (Vector3.down * (Time.deltaTime * 2));
    }

    private void Update()
    {
        if (Input.GetKeyDown("UpArrow"))
        {
            MoveUp();
        }

        if (Input.GetKeyDown("UpArrow"))
        {
            MoveDown();
        }
    }
}
