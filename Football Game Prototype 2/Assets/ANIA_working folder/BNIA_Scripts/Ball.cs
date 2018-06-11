using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{

    
    float turnRight;
    float turnleft;
    bool turning;
    public float launchSpeed;

    public Rigidbody rigidBody;
    private AudioSource audioSource;


    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

    }

    public void Launch(Vector3 velocity)
    {

        rigidBody.velocity = velocity;

      /*  if (turnSlider.value != 5)
        {
            turning = true;
        }*/

        audioSource = GetComponent<AudioSource>();
        //audioSource.Play();

    }



    // Update is called once per frame
    void Update()
    { 

       /* if (turning)
        {
            if (rigidBody.velocity.z < 10)
            {
                rigidBody.AddForce(transform.right * turnSlider.value);
            }
        }*/


    }
}
