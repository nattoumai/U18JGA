using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridContllore : MonoBehaviour {

	public GameObject target;
	float x_count;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//FPSControllerについて行くコード（Y座標もついて行く）
		transform.position = target.transform.position;
		//Y座標を0.5にするコード
		Vector3 pos = transform.position;
		pos.y = 0.5f;
		transform.position = pos;

		//target.transform.position.x % 5 = x_count; 

		if (target.transform.position.x % 5 >= -0.5f && 
			target.transform.position.x % 5 <= 0.5f && 
			target.transform.position.x >= 0.5f &&
			target.transform.position.x <= -0.5f) {
			Debug.Log ("!!!");
		}

	}

}
