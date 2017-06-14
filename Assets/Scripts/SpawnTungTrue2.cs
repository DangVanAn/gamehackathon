using UnityEngine;
using System.Collections;

public class SpawnTungTrue2 : MonoBehaviour {

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
		int getRoot = SpawnObjects.Instance.GetCurrentRandomNum ();
		Debug.Log ("Dang so random ne" + PlayerPrefs.GetInt ("random"));
		int randoms = Random.Range (0, 3);
		Debug.Log ("so random ..............................:" + randoms);
		int final = (getRoot * 3) + randoms;
		Debug.Log ("so random ..............................final:" + final);

		int[] listfalse = new int[9];
		int min = getRoot * 3;
		int max = min + 2;
		int j = 0;
		for (int i = 0; i < 12; i++) 
		{
			if (i < min || i > max) {
				listfalse [j] = i;
				j++;
			}
		}
		Debug.Log ("so random ..............................j:" + j);
		int randomFalse = Random.Range (0, 9);

		GameObject newObject = Instantiate (objectSprites [final]);
		newObject.tag = "clicktrue";
		newObject.transform.position = new Vector2 (Random.Range(this.objectMinX, this.objectMaxX), this.objectY);

		GameObject newObjectFalse = Instantiate (objectSprites [listfalse[randomFalse]]);
		newObjectFalse.tag = "clickfalse";
		newObjectFalse.transform.position = new Vector2 (Random.Range(this.objectMinX, this.objectMaxX), this.objectY);

		//GameObject objectSprite = objectSprites [Random.Range (0, this.objectSprites.Length)];
		//newObject = objectSprite;
	}
}
