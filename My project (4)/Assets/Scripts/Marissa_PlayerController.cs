using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marissa_PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    public float turnSpeed = 50.0f;
    public float horizontalInput;
    public float forwardInput;

    public Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // If moving forward, myAnim.SetInt("AnimState", 1);

        if (transform.position.z < -20)
        {
            myAnim.SetInteger("AnimState", 1);
            speed = 30;
        }


        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
