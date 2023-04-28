using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollsision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);

        if (collisionInfo.collider.tag == "obstical")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
           
        }
    }
    void FixedUpdate()
    {
       

    }

}
