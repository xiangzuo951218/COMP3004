﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableRotate : MonoBehaviour {

	// Use this for initialization


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			gameObject.transform.Rotate (new Vector3 (0f, 0f, 0.01f));
	}
		
}
