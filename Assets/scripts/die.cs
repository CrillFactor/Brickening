using UnityEngine;
using System.Collections;

public class die : MonoBehaviour {
	public AudioClip deadnoise;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D coll) {
		Score.game_over = 1;
		AudioSource.PlayClipAtPoint(deadnoise, transform.position);
		DestroyObject (coll.gameObject);
	}
}
