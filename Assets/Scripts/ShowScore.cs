using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {

	private int score = 0;

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = "Score: " + this.score;
	}

	public void incrementScore(int incrementValue) {
		this.score += incrementValue;
		GetComponent<Text> ().text = "Score: " + this.score;
		if (PlayerPrefs.GetInt ("highscore") < this.score) {
			PlayerPrefs.SetInt ("highscore", this.score);
		}
	}

	public void decrementScore(int incrementValue) {
		this.score -= incrementValue;
		GetComponent<Text> ().text = "Score: " + this.score;
	}

	public int getScore() {
		return this.score;
	}
}
