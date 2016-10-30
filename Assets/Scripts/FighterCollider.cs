using UnityEngine;
using System.Collections;

public class FighterCollider : MonoBehaviour {


		[SerializeField]
		GameObject explosion = null;

		void OnTriggerEnter2D(Collider2D other){


		if(other.gameObject.tag == "fuel") {

				//Debug.Log ("Collision with fuel");
			//increase a point in every collision with fuel and Increase health by point 5
				Player.Instance.Points++;
			Player.Instance.Health = Player.Instance.Health + 5;

		} else if (other.gameObject.tag=="enemy"){
				
				//Update health, every collision 15 points decrease
				Player.Instance.Health = Player.Instance.Health - 15;

			//Show explosion
			GameObject e = Instantiate(explosion);
			e.transform.position = other.gameObject.transform.position;
				EnemyController ec = other.gameObject.GetComponent<EnemyController> ();
			if (ec != null) {
				ec.Reset ();
			}
				
				
				//Play explosion sound
				AudioSource asrc = gameObject.GetComponent<AudioSource> ();
            if (asrc != null) {
                asrc.Play ();
            }

            if (ec != null) {
                ec.Reset ();
            }

			}

		}

		
	}


