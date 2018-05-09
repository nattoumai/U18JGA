using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliding : MonoBehaviour {

	//色々変数設定
	public float speed = 10;
	public float timer;
	public GameObject camera2;
	public float Distance = 200;



	// Use this for initialization
	void Start () {

		speed = 2;



	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.LeftControl)) {

			//timerにTime.deltaTimeをプラス

				
				transform.position += camera2.transform.forward * speed;


		}
		//Ray rayright = Camera.main.ScreenPointToRay (camera2.transform.right);
		Ray rayforward = Camera.main.ScreenPointToRay (camera2.transform.forward);
		//Ray rayleft = Camera.main.ScreenPointToRay (camera2.transform.right * -1);
		//Ray rayback = Camera.main.ScreenPointToRay (camera2.transform.forward * -1);
		RaycastHit hit;
		//Debug.DrawLine (rayright.origin, transform.position, Color.red);
		Debug.DrawLine (rayforward.origin, transform.position, Color.black);
		//Debug.DrawLine (rayleft.origin, transform.position, Color.green);
		//Debug.DrawLine (rayback.origin, transform.position, Color.blue);*/

		if (Physics.Raycast (rayforward, out hit, Distance)) {
			//Rayが当たるオブジェクトがあった場合はそのオブジェクト名をログに表示
			//Debug.Log(hit.collider.gameObject.name);
			speed = 0;
			Debug.Log ("RayHit");
		} else {
			speed = 2;
			//Debug.Log ("RayHitしてないよ");
		}

	}
}
