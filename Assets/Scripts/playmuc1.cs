using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playmuc1 : MonoBehaviour {

	public void PlayMuc1()
	{
		Application.LoadLevel ("Game");
	}

	public void PlayMuc2()
	{
		Application.LoadLevel ("Game2");
	}

	public void PlayMuc3()
	{
		Application.LoadLevel ("Game3");
	}

	public void PlayBack()
	{
		Application.LoadLevel ("MainMenu");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
