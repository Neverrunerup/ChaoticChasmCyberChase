using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float Forwardforce = 1000f;
    public float sidewaysforce = 500f;

    // Start is called before the first frame update
    void Start ()
    {
        Debug.Log("Start");
        rb.useGravity = true;
    
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        rb.AddForce(0, 0, Forwardforce * Time.deltaTime);


        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0,-Forwardforce * Time.deltaTime , ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
