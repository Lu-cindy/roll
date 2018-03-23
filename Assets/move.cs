using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class move : MonoBehaviour {
 
	Rigidbody rb;

    public Text countText;
    public Text winText;
    public Text myTime;

    int count;
    DateTime curr;
	public float speed;
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody> ();

        count = 0;
        countText.text = "分數 : "+ count.ToString();
        winText.text = "";

        curr = DateTime.Now;

        myTime.text = "30";
	}
	
	// Update is called once per frame
	void Update () {

		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");
		//transform.Translate(x,0,z);

		rb.AddForce (new Vector3(x,0,z));

        TimeSpan ts = DateTime.Now - curr;

        if (ts.Seconds < 30)
        {
            myTime.text = (30 - ts.Seconds).ToString() + "." + (1000 - ts.Milliseconds).ToString();
        }
        else
        {
            myTime.text = "0";
            winText.text = "You Lose !";
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("pick"))
        {
            other.gameObject.SetActive(false);

            count++;

            countText.text = "分數 : "+ count.ToString();

            if(count == 4)
            {
                winText.text = "You Win !";
            }
        }
    }
}
