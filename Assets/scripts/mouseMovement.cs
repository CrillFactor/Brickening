using UnityEngine;
using System.Collections;

public class mouseMovement : MonoBehaviour {
	public float max_edge;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mose = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
		// camera.ScreenToWorldPoint(new Vector3(100, 100, camera.nearClipPlane));
		if (mose.x > max_edge) {
			mose.x = max_edge;
		}
		if (mose.x < -max_edge) {
			mose.x = -max_edge;
		}
		Vector2 padle = transform.position;
		transform.position = new Vector2 (mose.x, padle.y);

	}
}
