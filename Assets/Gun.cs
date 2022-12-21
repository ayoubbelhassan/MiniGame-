using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bultspan;
    public GameObject builtprefaps;
    public float bultSpedd = 10;
    public Rigidbody rb;
    
    void Update()
    {
        rb.AddForce(50,0,0) ;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(builtprefaps, bultspan.position, bultspan.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bultspan.forward * bultSpedd;
        }
    }

}
