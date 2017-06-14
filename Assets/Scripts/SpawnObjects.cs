using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour {
	public static SpawnObjects Instance;
	[SerializeField]
	private float spawnInterval, objectMinX, objectMaxX, objectY;

	[SerializeField]
	private GameObject[] objectSprites;



	// Use this for initialization
	void Start () {
		Instance = this;
		InvokeRepeating ("spawnObject", 1, this.spawnInterval);
	}

	void Update()
	{
		if (ShowLives.Instance.Getlive () <= 0) {
			GameObject rootOb = GameObject.FindGameObjectWithTag ("packman");
			Destroy (rootOb);
			CancelInvoke ("spawnObject");
		}
	}

	private int curSpawnNum = -1;

	public int GetCurrentRandomNum() 
	{
		return curSpawnNum;
	}

	private void spawnObject() {
		curSpawnNum = Random.Range (0, this.objectSprites.Length);
		PlayerPrefs.SetInt ("random", curSpawnNum);
		GameObject newObject = Instantiate (objectSprites [curSpawnNum]);
		newObject.transform.position = new Vector2 (Random.Range(this.objectMinX, this.objectMaxX), this.objectY);

		//GameObject objectSprite = objectSprites [Random.Range (0, this.objectSprites.Length)];
		//newObject = objectSprite;
	}
}
