using UnityEngine;
using System.Collections;

public class FighterController : MonoBehaviour {

	[SerializeField]
	private float speed;

	private Transform _transform;
	private Vector2 _currentPosition;
	private float _playerInput;
	private float _playerInput2;

	// Use this for initialization
	void Start () {

		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
	}

	// Update is called once per frame
	void FixedUpdate () {

		_playerInput = Input.GetAxis ("Horizontal");
		_playerInput2 = Input.GetAxis ("Vertical");
		_currentPosition = _transform.position;
		//move right
		if (_playerInput > 0) {
			_currentPosition += new Vector2 (speed, 0);
		}
		//move left
		if (_playerInput < 0) {
			_currentPosition -= new Vector2 (speed, 0);
		}
		//move up
		if (_playerInput2 > 0) { 
			_currentPosition += new Vector2 (0, speed); 
		}
		//move down
		if (_playerInput2 < 0) { 
			_currentPosition -= new Vector2 (0, speed); 
		} 
		//fix boundarues
		fixBoundaries ();
		_transform.position = _currentPosition;
	}


	private void fixBoundaries(){
		//fixed left,right, upper and lower boundaries for players
		if (_currentPosition.x < -24.50f) {
			_currentPosition.x = -24.50f;
		}
		if (_currentPosition.x > 1.0f) {
			_currentPosition.x = 1.0f;
		}
		if (_currentPosition.y < -3.15f) {
			_currentPosition.y = -3.15f;
		}
		if (_currentPosition.y > 4.47f) {
			_currentPosition.y = 4.47f;
		}
	}


}
