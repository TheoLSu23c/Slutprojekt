using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    Rigidbody myRigidBody;
    float Cooldown;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Cooldown -= Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
        {
            myRigidBody.AddForce(new Vector3(1, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            myRigidBody.AddForce(new Vector3(-1, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.Space) && myRigidBody.velocity.y == 0)
        {
            myRigidBody.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.E) && Cooldown<=0)
        { 
            myRigidBody.AddForce(myRigidBody.velocity,ForceMode.Impulse);
            Cooldown = 1;
        }
        
          
                
    }
}
