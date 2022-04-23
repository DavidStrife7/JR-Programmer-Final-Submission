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
    public virtual void MoveUp()
    {
        thisBall.position += (Vector3.up * Time.deltaTime);
    }

    public virtual void MoveDown()
    {
        thisBall.position += (Vector3.down * Time.deltaTime);
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
