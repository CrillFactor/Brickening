using UnityEngine;
using System.Collections;

public class createLife : MonoBehaviour {
	public GameObject lifebrick;
	public int brickrows;
	public float gridWidth;
	// Use this for initialization
	void Start () {
		for (int i=0; i < brickrows; i++) {
			Vector2 spawnPosition = transform.position;
			spawnPosition.x += i * (gridWidth / brickrows);
			Instantiate (lifebrick,spawnPosition,transform.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnDrawGizmos () {
		for (int i=0; i < brickrows; i++) {
			Vector2 spawnPosition = transform.position;
			spawnPosition.x += i * (gridWidth / brickrows);
			Gizmos.DrawLine (spawnPosition-Vector2.right*0.05f,spawnPosition+Vector2.right*0.05f);
		}
	}
}
