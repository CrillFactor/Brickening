using UnityEngine;
using System.Collections;

public class LifeCollision : MonoBehaviour {
	
	public AudioClip lifenoise;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D (Collision2D coll) {
		//		if (coll.gameObject.transform.position.y > transform.position.y) {
		//			Debug.Log (coll.contacts);
		AudioSource.PlayClipAtPoint(lifenoise, transform.position);
		//		}
		Score.life_lost ++;
		Destroy (gameObject);
	}

}
