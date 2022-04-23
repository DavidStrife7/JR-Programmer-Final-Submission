using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDefault : MonoBehaviour
{
    private Transform thisBall;
    private void Start()
    {
        thisBall = GetComponent<Transform>();
    }
    public virtual void MoveUp() // POLYMORPHISM
    {
        thisBall.position += (Vector3.up * Time.deltaTime);
    }

    public virtual void MoveDown() // POLYMORPHISM
    {
        thisBall.position += (Vector3.down * Time.deltaTime);
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
