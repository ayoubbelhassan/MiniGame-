
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    
     public Rigidbody rb;
     public float speed;
    public float Sidesspeed;
   

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(speed* Time.deltaTime, 0f,0f);
        if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(0f, 0f, -Sidesspeed* Time.deltaTime,ForceMode.VelocityChange);

        if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(0f, 0f, Sidesspeed * Time.deltaTime, ForceMode.VelocityChange);

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
       
    }
    public void LeftMove()
    {
        rb.AddForce(0f, 0f, Sidesspeed * Time.deltaTime, ForceMode.VelocityChange);
    }
    public void RightMove()
    {
        rb.AddForce(0f, 0f, -Sidesspeed * Time.deltaTime, ForceMode.VelocityChange);
    }
}
