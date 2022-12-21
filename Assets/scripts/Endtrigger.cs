using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public GameManager gameManager;
     void OnTriggerEnter()
    {
        gameManager.CompleteLevel();


    }
}
