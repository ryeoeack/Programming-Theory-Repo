using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float strafeSpeed;
    public float backwardSpeed;
    public float turnSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0,vertical);
        
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Strafe();
        }
        else
        {
            if(vertical > 0)
            {
                transform.Translate(movement * speed * Time.deltaTime);
            } else { transform.Translate(movement * backwardSpeed * Time.deltaTime); }
            
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontal);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void Strafe()
    {
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * strafeSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * speed * 0.5f * Time.deltaTime);
    }


}
