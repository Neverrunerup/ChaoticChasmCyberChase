using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
   
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(1f, 1f, 1f, Space.Self);
    }
}
