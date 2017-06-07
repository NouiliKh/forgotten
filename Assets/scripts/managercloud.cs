using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managercloud : MonoBehaviour {
    public GameObject clouds;
	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
	}



    void OnCollisionEnter(Collision collision)
    {
      //  if (collision.gameObject.tag == "collid")
       // {
            Debug.Log("sqdqd");
            Instantiate(clouds, clouds.transform.position, clouds.transform.rotation);
       //xã }

    }


}
