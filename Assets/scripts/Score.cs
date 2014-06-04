using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public static int score = 0;
	public static int score_update = 0;
	public static int life_lost = 0;
	public static int bricks_destroyed = 0;
	public static int game_over = -1; // -1 = START SCREEN, 0 = IN GAME, 1 = GAME OVER SCREEN
	public int update_speed = 1;
	public GameObject ball;
	public GameObject createBricks;
	public GameObject createLife;
	public GUIStyle styledefault;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (score_update > 0) {
			// update the score one point at a time, per frame
			if (score_update > 100) {
				update_speed = Mathf.RoundToInt(score_update / 50);
			} else {
				update_speed = 1;
			}
			score_update -= update_speed;
			score += update_speed;
		}
		if (game_over == -1) { // from the START screen
			if (Input.anyKeyDown) {
				game_over = 0;
				Vector3 mose = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
				// camera.ScreenToWorldPoint(new Vector3(100, 100, camera.nearClipPlane));
				if (mose.x > 14) {
					mose.x = 14.0F;
				}
				if (mose.x < -14) {
					mose.x = -14.0F;
				}
				Vector2 bal;
				bal.x = mose.x;
				bal.y = -2.8F;
				Instantiate(ball, bal,transform.rotation);
			}
		} else if (game_over == 1) { // from the GAME OVER screen
			if (Input.anyKeyDown) {
				// reset all counters and game objects

				score = 0;
				score_update = 0;
				life_lost = 0;
				bricks_destroyed = 0;

				GameObject[] uselessBrick;
				uselessBrick = GameObject.FindGameObjectsWithTag("brick");
				foreach (GameObject mistake in uselessBrick) {
					GameObject.Destroy(mistake);
				}
				GameObject[] uselessSpawn;
				uselessSpawn = GameObject.FindGameObjectsWithTag("Respawn");
				foreach (GameObject mistake in uselessSpawn) {
					GameObject.Destroy(mistake);
				}
//				Instantiate(createBricks);
//				Instantiate(createLife);
				game_over = -1;

				Vector2 bs;
				bs.x = gameController.brickSpawnX;
				bs.y = gameController.brickSpawnY;
				Vector2 ls;
				ls.x = gameController.lifeSpawnX;
				ls.y = gameController.lifeSpawnY;
				Instantiate (createBricks,bs,transform.rotation);
				Instantiate (createLife,ls,transform.rotation);
				
			}
		}
	}

	private void OnGUI() {
		GUI.Label(new Rect(10,10,100,90), score.ToString(),styledefault);
//		GUI.Label(new Rect(110,10,100,90), bricks_destroyed.ToString(),styledefault);
//		GUI.Label(new Rect(210,10,100,90), life_lost.ToString(),styledefault);
		GUI.Label(new Rect(Screen.width-150,10,150,90),"THE BRICKENING",styledefault);
		if (game_over == -1) {
			GUI.Button(new Rect((Screen.width/2.0f)-30,10,120,120),"CLICK TO START",styledefault);
		}
		if (game_over == 1) {
			GUI.Label(new Rect(Screen.width/2.0f,10,120,120),"GAME OVER",styledefault);
		}
	}
}

