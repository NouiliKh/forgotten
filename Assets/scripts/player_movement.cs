using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {
    Rigidbody2D rBody;
    Animator anim;
    Transform trans;
  
    // Use this for initialization
    void Start()
    {
        //rBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        transform.position = new Vector3(-19.73f, -2.523f,-0.015f);
        transform.rotation = transform.rotation;    //new Quaternion(40.1f, -42.859f, 60.011f,100);
       // rBody.rotation = 67f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (movement_vector != Vector2.zero)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
            anim.SetBool("iswalking", true);
            anim.SetFloat("input_x", movement_vector.x);
            anim.SetFloat("input_y", movement_vector.y);
            //rBody.MovePosition(rBody.position  +  movement_vector * Time.fixedDeltaTime);
     //       this.rigidbody.MovePosition(new Vector3(this.rigidbody.position.x + this.currentSpeedX, this.rigidbody.position.y + this.currentSpeedY, this.rigidbody.position.z));

        }
        else
        {
            anim.SetBool("iswalking", false);
        }

        this.transform.position = new Vector2(this.transform.position.x + movement_vector.x*0.04f, this.transform.position.y + movement_vector.y * 0.04f);


    }
}