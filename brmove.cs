﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brmove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(-1 * Time.deltaTime, transform.position.y, 0));
		
	}
}
