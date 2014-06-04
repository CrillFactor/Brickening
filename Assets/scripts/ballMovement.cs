using UnityEngine;
using System.Collections;

public class ballMovement : MonoBehaviour {
	public float xvel = 100;
	public float yvel = 100;
	public float speedup = 1.003f;
	public GameObject paddle;
	float noAccidents = 0.0f;
	Vector2 curpos;
	// Use this for initialization
	void Start () {
		rigidbody2D.AddForce (new Vector2(xvel, yvel));
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 vel = rigidbody2D.velocity;
		if (vel.y == 0) {
			vel.y = Random.Range(-2.8F, 2.8F);
			rigidbody2D.velocity = vel;
		}
		noAccidents += 0.01f;
		if (noAccidents > 0.45f) {
			//Debug.Log (vel.y);
			// noAccidents = 0.0f;
			if (vel.x == 0) {
				vel.x = 0.5f;
			}
		}
		if (noAccidents > 1.0f) {
			if (vel.x == 0) {
				vel.x = -0.5f;
			}
		}
	}
	void OnCollisionEnter2D (Collision2D coll) {
		Vector2 vel = rigidbody2D.velocity;
		vel.x = vel.x * speedup;
		vel.y = vel.y * speedup;
		rigidbody2D.velocity = vel;
		noAccidents = 0.0f;
	}
}