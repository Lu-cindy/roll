using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class cameramove : MonoBehaviour {

	public Transform player;

	bool bchnage = true;
	Vector3 offset;
	Vector3 change;
    
    DateTime curr;

	// Use this for initialization
	void Start () {

		offset = transform.position - player.position;
		change = new Vector3 (0,2,0);

        curr = DateTime.Now;

	}
	
	// Update is called once per frame
	void Update () {

        

		if (Input.GetKey (KeyCode.C))
		{
            TimeSpan ts = DateTime.Now - curr;
			
            if( ts.Seconds > 1)
                bchnage = !bchnage;
            Debug.Log("change camera");

            curr = DateTime.Now;
		}

		if(bchnage)
			transform.position = player.position + offset+change;
		else
			transform.position = player.position + offset;

	}
}
