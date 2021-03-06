﻿using UnityEngine;
using System.Collections;

public class GroundController : MonoBehaviour {

	[SerializeField]
	private float speed;

	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
		//Reset ();
	}

	// Update is called once per frame
	void Update () {
		_currentPosition = _transform.position;

		_currentPosition -= new Vector2 (speed, 0);
		_transform.position = _currentPosition;

		if (_currentPosition.x <= -20.0f) {
			Reset ();
		}
	}

	private void Reset(){

		_currentPosition = new Vector2 (-0.50f, 0);
		_transform.position = _currentPosition;
	}
}

