using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	[SerializeField]
	private Vector2 speed = Vector2.zero;

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
		
		Vector2 currSpeed = new Vector2 (speed.x ,  speed.y);
		_currentPosition -= currSpeed;
		_transform.position = _currentPosition;

		if (_currentPosition.x <= -26) {
			Reset ();
		}
	}

	public void Reset(){
		
		_currentPosition = new Vector2 (6, Random.Range(-2.250f,3.4f));
		_transform.position = _currentPosition;

	}
}
