﻿using UnityEngine;
using System.Collections;

public class planeta : MonoBehaviour {
	public GameObject center;
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(center.transform.position , Vector3.up, speed * Time.deltaTime);
	
	}
}
