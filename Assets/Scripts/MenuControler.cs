using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControler : MonoBehaviour {

	public void play(){
		Application.LoadLevel ("play");

	}
	public void guide(){
		Application.LoadLevel ("guide");
	}

	public void dc(){
		Application.LoadLevel ("hs");
	}
	public void aboutus(){
		Application.LoadLevel ("aboutus");
	}
	public void exit(){
		Debug.Log ("sdf");
		Application.Quit ();

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		
	}
}
