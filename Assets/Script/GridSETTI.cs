using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSETTI : MonoBehaviour {
	public GameObject m_Grid;
	int framecount = 0;
	int Zcount = 0;
	int Behavior = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Behavior == 0) {
			//カウント
			framecount += 1;

			//生成
			Instantiate (m_Grid, transform.position, transform.rotation);
			if (Zcount % 2 == 0) {
				//移動（x座標を+1）
				Vector3 posX = transform.position;
				posX.x = 5;
				transform.position += posX;
			} else if (Zcount % 2 == 1) {
				Vector3 posX = transform.position;
				posX.x = 5;
				transform.position -= posX;
			}

			//Y座標移動用意
			Vector3 posY = transform.position;
			posY.x = 5;

			/*//Y座標移動
			if (framecount == 300) {
				transform.position += posY;
				framecount = 0;
				Zcount += 1;
				Debug.Log ("切り替えし");
			}
			if (Zcount == 300) {
				Behavior = 1;
			}*/
			}
		}
}
