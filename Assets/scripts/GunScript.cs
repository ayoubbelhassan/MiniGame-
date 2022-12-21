using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public Transform gun;
    public GameObject prefap;
    public float Spedd = 1;
    public float RightLeftMovement;
    public Rigidbody rb;
     void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb.AddForce(50 * Time.deltaTime, 0, RightLeftMovement);
        while (true)
        {
            Invoke("AddEneme", 6);
            Invoke("AddEneme", 6);
        }
      
        
    }
    void AddEneme()
    {
        var bullet = Instantiate(prefap, gun.position, gun.rotation);
        bullet.GetComponent<Rigidbody>().velocity = gun.forward * Spedd;

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "block")
        {
            RightLeftMovement = RightLeftMovement * (-1);
        }
    }
}
