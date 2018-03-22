using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour {

	public Transform player;

	bool bchnage = true;
	Vector3 offset;
	Vector3 change;

	// Use this for initialization
	void Start () {

		offset = transform.position - player.position;
		change = new Vector3 (0,2,0);

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.C))
		{
			bchnage = !bchnage;
		}

		if(bchnage)
			transform.position = player.position + offset+change;
		else
			transform.position = player.position + offset;

	}
}
