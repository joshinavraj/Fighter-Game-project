using UnityEngine;
using System.Collections;

public class FuelController : MonoBehaviour {

	[SerializeField]
	private float speed= 0f;

	private Transform _transform;
	private Vector2 _currentPosition;


	// Use this for initialization
	void Start () {

		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
		Reset ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		_currentPosition = _transform.position;
		// for fuel moving upward direction
		_currentPosition += new Vector2 (0, speed);
		_transform.position = _currentPosition;

		if (_currentPosition.y >= 5.3) {
			Reset ();
		}
	}

	private void Reset(){
		// fuel reset from ramdon position of x to appear from different point  
		//and taking random in y to appear in random time (with help of speed),
		_currentPosition = new Vector2 (Random.Range (-24f, 0f),  Random.Range (-20.0f, 10f));
		_transform.position = _currentPosition;
	}
}
