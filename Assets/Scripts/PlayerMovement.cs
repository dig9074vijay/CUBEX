using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sideForce = 500f;
    public Joystick joystick;
    

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.position.z > 370f)
        {
            forwardForce = 2400f;
        }
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(joystick.Horizontal > 0f)
        {
            rb.AddForce(sideForce * Time.deltaTime * joystick.Horizontal, 0, 0, ForceMode.VelocityChange);
        }
        if(joystick.Horizontal < 0f)
        {
            rb.AddForce(sideForce * Time.deltaTime * joystick.Horizontal, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -0.1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
