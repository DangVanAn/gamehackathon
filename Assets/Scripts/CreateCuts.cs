using UnityEngine;
using System.Collections;

public class CreateCuts : MonoBehaviour {

	[SerializeField]
	private GameObject cut;
	[SerializeField]
	private float cutDestroyTime;

	private bool dragging = false;
	private Vector2 swipeStart;
    TouchPhase touchPhase = TouchPhase.Began;

    // Update is called once per frame
    void Update () {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == touchPhase)
        {
            
        }
        if (Input.GetMouseButtonDown (0)) {
            
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
            if (hit != null && hit.collider != null)
            {
                GameObject scoreText = GameObject.Find("ScoreText");
				if (hit.collider.gameObject.tag == "clickfalse")
				{
					Debug.Log(".......................Spawner false");
					SpecialEffectsHelper.Instance.Explosion(hit.collider.transform.position);
					scoreText.GetComponent<ShowScore>().decrementScore(1);
					Destroy(hit.collider.gameObject);
				}
				if (hit.collider.gameObject.tag == "clicktrue")
				{
					Debug.Log("........................Spawner true");
					int i = SpawnObjects.Instance.GetCurrentRandomNum ();
					GameObject rootOb = GameObject.FindGameObjectWithTag (i.ToString());
					SpecialEffectsHelper.Instance.Explosion(rootOb.transform.position);
					Destroy (rootOb);
				
					SpecialEffectsHelper.Instance.Explosion(hit.collider.transform.position);
					scoreText.GetComponent<ShowScore>().incrementScore(1);
					Destroy(hit.collider.gameObject);
				}
                else if (hit.collider.gameObject.tag == "Bomb")
                {
                    SpecialEffectsHelper.Instance.ExplosionFire(hit.collider.transform.position);
                    GameObject playerLives = GameObject.Find("PlayerLives");
                    playerLives.GetComponent<ShowLives>().looseLife();
					Destroy(hit.collider.gameObject);
                }
                //Destroy(hit.collider.gameObject);
            }
        }
	}
}
