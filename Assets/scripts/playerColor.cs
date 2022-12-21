using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerColor : MonoBehaviour
{
    // Start is called before the first frame update
    public Material MyMaterial;
    

    // Update is called once per frame
   
    public void OnTriggerEnter(Collider other)
    {
        if(MyMaterial.color == other.gameObject.GetComponent<Renderer>().material.color)
        {
            Destroy(other.gameObject);
        }
       
        
    }
  
}
