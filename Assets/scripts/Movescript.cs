using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movescript : MonoBehaviour
{
    public float Moveforce = 1000000f;
    public Rigidbody rb;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, Moveforce * Time.deltaTime);

    }
}
