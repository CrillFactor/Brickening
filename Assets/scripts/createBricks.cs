using UnityEngine;
using System.Collections;

public class createBricks : MonoBehaviour {
	public GameObject normalbrick;
	public int brickrows;
	public int brickcolumns;
	public float gridWidth;
	public float gridHeight;
	// Use this for initialization
	void Start () {
		for (int i=0; i < brickrows; i++) {
			for (int j=0; j < brickcolumns; j++) {
				Vector2 spawnPosition = transform.position;
				spawnPosition.x += i * (gridWidth / brickrows);
				spawnPosition.y += j * (gridHeight / brickcolumns);
				Instantiate (normalbrick,spawnPosition,transform.rotation);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDrawGizmos () {
		for (int i=0; i < brickrows; i++) {
			for (int j=0; j < brickcolumns; j++) {
				Vector2 spawnPosition = transform.position;
				spawnPosition.x += i * (gridWidth / brickrows);
				spawnPosition.y += j * (gridHeight / brickcolumns);
						Gizmos.DrawLine (spawnPosition-Vector2.right*0.05f,spawnPosition+Vector2.right*0.05f);
			}
		}
	}
}
