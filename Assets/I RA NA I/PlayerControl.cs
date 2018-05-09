using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerControl : MonoBehaviour {

	int PlayerGoSpeed = 100;   //プレイヤー前進速度
	int PlayerBackSpeed = 70;  //プレイヤー後退速度
	int PlayerRaLSpeed = 50;   //プレイヤー横移動速度
	int PlayerJumpSpeed = 10;  //プレイヤージャンプスピード

	float Stime = 1; //プレイヤースライディングタイム
	int count = 0; //プレイヤー


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//プレイヤー前進
		if (Input.GetKey (KeyCode.W)) {
			transform.position += new Vector3 (0, 0, PlayerGoSpeed * Time.deltaTime);
		}

		//プレイヤー後退
		if (Input.GetKey (KeyCode.S)) {
			transform.position += new Vector3 (0, 0, -PlayerBackSpeed * Time.deltaTime);
		}

		//プレイヤー左進
		if (Input.GetKey (KeyCode.A)) {
			transform.position += new Vector3 (-PlayerRaLSpeed * Time.deltaTime, 0, 0);
		}

		//プレイヤー右進
		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (PlayerRaLSpeed * Time.deltaTime, 0, 0);
		}

		//プレイヤージャンプ
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody> ().velocity = new Vector3 (0, PlayerJumpSpeed, 0);
		}

		//プレイヤーしゃがむ
		if (Input.GetKeyDown (KeyCode.C)) {
		}

		//プレイヤーうつ伏せ
		if (Input.GetKeyDown (KeyCode.X)) {
		}

		//プレイヤー走る
		if (Input.GetKeyDown (KeyCode.LeftShift)) {
			count = 2;
		}
		if (Input.GetKeyUp (KeyCode.LeftShift)) {
			count = 0;
		}

		//プレイヤースライディング
		if (Input.GetKeyDown (KeyCode.LeftControl)) {
			count = 1;
		}

		//ノーマルの時（countが０の時）の処理
		if(count == 0){
			PlayerGoSpeed = 100;
			PlayerBackSpeed = 70;
			PlayerRaLSpeed = 50;

		//スライディングの時(countが１の時）の処理
	    }else if (count == 1) {
			Stime -= Time.deltaTime;
			PlayerGoSpeed = PlayerBackSpeed = PlayerRaLSpeed = 200;

		    //スライディングタイムが0になった時
		    if (Stime <= 0) {
				count = 0;
				Stime = 1;
				PlayerGoSpeed = 100;
				PlayerBackSpeed = 70;
				PlayerRaLSpeed = 50;
			}

		//走る時（countが２の時）の処理
		} else if (count == 2) {
			PlayerGoSpeed = 150;
		}

		/*//プレイヤー左に覗く
		if (Input.GetKeyDown (KeyCode.Q)) {
		}

		//プレイヤー右に覗く
		if (Input.GetKeyDown (KeyCode.E)) {
		}*/

		//プレイヤーアクション（ものを拾う、ドアを開けるなどなど・・・）
		if (Input.GetKeyDown (KeyCode.F)) {
		}

	}
}
