using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutIcon : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision) {
		Debug.Log ("Cut Icon");
		if (collision.gameObject.tag == "packman") {
			Destroy (this.gameObject);
			GameObject playerLives = GameObject.Find ("PlayerLives");
			playerLives.GetComponent<ShowLives> ().looseLife ();
		}
	}
}
