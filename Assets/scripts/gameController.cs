using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {

	public GameObject createBricks;
//	public int brickRows = 13;
//	public int brickColumns = 5;
//	public float brickWidth = 17.58F;
//	public float brickHeight = 5.1F;
	public static float brickSpawnX = -6.552F;
	public static float brickSpawnY = 0.1903F;

	public static float lifeSpawnX = -7.683F;
	public static float lifeSpawnY = -4.699F;
//	public int lifeColumns = 26;
//	public float lifeWidth = 30.24F;

	public GameObject createLife;
	// Use this for initialization
	void Start () {
		Vector2 bs;
		bs.x = brickSpawnX;
		bs.y = brickSpawnY;
		Vector2 ls;
		ls.x = lifeSpawnX;
		ls.y = lifeSpawnY;
		Instantiate (createBricks,bs,transform.rotation);
		Instantiate (createLife,ls,transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
