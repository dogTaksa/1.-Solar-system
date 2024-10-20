using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;
    //int count = 0;
    void Update()
    {
        //count++;

        //Component transform = GetComponent<Transform>();

        //if (count % 12 == 0)
        //{
        //    transform.transform.Rotate(0, 1, 0);
        //}

        Component transform = GetComponent<Transform>();
        transform.transform.Rotate(0, speed, 0);
    }
}
