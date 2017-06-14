using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour {

	/// <summary>
	/// Projectile speed
	/// </summary>
	public Vector2 speed = new Vector2(10, 10);

	/// <summary>
	/// Moving direction
	/// </summary>
	public Vector2 direction = new Vector2(-1, 0);
	// Use this for initialization
	private Vector2 movement;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// 1 - Movement
		movement = new Vector2(
			speed.x * direction.x,
			speed.y * direction.y);
	}

	void FixedUpdate()
	{
		// Apply movement to the rigidbody
		GetComponent<Rigidbody2D>().velocity = movement;
	}
}
