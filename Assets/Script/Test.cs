using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	int speed = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position += transform.TransformDirection(Vector3.forward)*speed*Time.deltaTime;
		if (Input.GetMouseButtonDown (1)) {
			GetComponent<Rigidbody> ().velocity = transform.forward * speed;
			//Debug.Log ("クリックしたよ！");
		}
		
	}
}
