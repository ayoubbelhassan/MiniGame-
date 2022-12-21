using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public Move movement;
     void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obstacle")
        {
            
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
