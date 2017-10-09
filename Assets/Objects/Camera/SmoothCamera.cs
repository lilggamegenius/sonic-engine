﻿using UnityEngine;

public class SmoothCamera : MonoBehaviour{

	public Transform target;
	public bool smooth = true;
	public float smoothSpeed = 0.125f;
	public Vector3 offset = new Vector3(0, 0, -2.5f);

	private void Start(){
		transform.position = target.position + offset;
	}

	// Update is called once per frame
	private void FixedUpdate (){
		Vector3 desiredPos = target.position + offset;
		transform.position = smooth ? Vector3.Lerp(transform.position, desiredPos, smoothSpeed) : desiredPos;
	}
}