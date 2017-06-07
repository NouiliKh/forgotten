using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
     public Transform Target;
    //public float m_speed=0f;
     Camera mycam;
	// Use this for initialization
	void Start () {
        mycam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        mycam.orthographicSize = ((Screen.height / 100f) / 4f);
        if (Target)
        {
            transform.position = Vector3.Lerp(transform.position, Target.position, 0.1f)+new Vector3(0,0,-10);
            //transform.position =  Target.position ;
        }
	}
}
