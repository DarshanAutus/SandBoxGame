﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBook2 : MonoBehaviour {
	public GameObject Book2;
	public static int xforbook2off ;
	void Start (){
		//transform.Rotate (new Vector3  (90	, 90, 90));
		Debug.Log ("test script on Book2 is runing");
		//xforbook2off = 3;
	}
	// Update is called once per frame
	void Update () {
		//xforbook2off =   UIgameObject.xforbook2off ;
		if (  xforbook2off == 1){
			transform.Rotate (new Vector3  (90	, 90, 90));
			xforbook2off  = 2;
		}
		Debug.Log ("update script b2 runing");
		//transform.Rotate (new Vector3  (90	, 90, 90));
		//transform.Translate (Input.GetAxis("Horizontal")*0.3f,0.3f*Input.GetAxis("Vertical"),Input.GetAxis("Horizontal")*0.3f);
		//Book2.GameObject.SetActive (false);
	}
}
