using UnityEngine;
using System.Collections;

public class SpawnTungFalse : MonoBehaviour {

	[SerializeField]
	private float spawnInterval, objectMinX, objectMaxX, objectY;

	[SerializeField]
	private GameObject[] objectSprites;

	public float con1s = 0f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("spawnObject", 1 + con1s, this.spawnInterval);
		con1s = 0;
	}

	private void spawnObject() {
		GameObject newObject = Instantiate (objectSprites [Random.Range (0, this.objectSprites.Length)]);
		newObject.transform.position = new Vector2 (Random.Range(this.objectMinX, this.objectMaxX), this.objectY);

		//GameObject objectSprite = objectSprites [Random.Range (0, this.objectSprites.Length)];
		//newObject = objectSprite;
	}
}
