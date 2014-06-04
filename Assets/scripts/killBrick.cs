using UnityEngine;
using System.Collections;
// [RequireComponent(typeof(AudioSource))]
public class killBrick : MonoBehaviour {
	public AudioClip impact;
	public AudioClip normal;
	public GameObject PlayerStats;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D coll) {
		foreach (ContactPoint2D cont in coll.contacts) {
			// Debug.Log (cont.point.y);
			double amt = cont.point.y - transform.position.y;
			if (cont.point.y > transform.position.y && amt > 0.16) {
				// Debug.Log ("   "+amt);
				AudioSource.PlayClipAtPoint(impact, transform.position);
				Score.score_update += (25 + (Score.life_lost * 10));
			} else {
//				Debug.Log (amt);
				AudioSource.PlayClipAtPoint(normal, transform.position);
				Score.score_update += (10 + (Score.life_lost * 10));
			}
		}
		Score.bricks_destroyed++;
		Destroy (gameObject);
	}
}
