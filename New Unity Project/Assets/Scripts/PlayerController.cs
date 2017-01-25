// Player Controller which controls most of the game logic.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	public float speed;
	public Rigidbody pacman;
	public int score;
	public Text scoreDisplay;
	public int lives;
	public Text livesDisplay;
	private Transform pc;
	public int winScore;
	public Text winText;
	public Text loseText;

	// Initialization values and player object.
	void Start () {
		pc = this.transform;
		pacman = GetComponent<Rigidbody> ();
		score = 0;

		winText.text = "";
		loseText.text = "";

		UpdateScore ();
		UpdateLives ();

	}
	
	// Updating player controller.
	void Update () {

		// Player input.
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 move = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		pacman.AddForce (move * speed);

		// End Game Logic.
		if (lives == 0) {
			loseText.text = "You Lose :(";
		}

		if (score == winScore) {
			winText.text = "YOU WIN!";
		}
	}

	// Trigger events for colliding with coins and ghouls.
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Coin")) {

			// Getting a coin increases score.
			other.gameObject.SetActive (false);
			score++;
			UpdateScore ();

		} else if (other.gameObject.CompareTag ("Ghoul")) {

			// Restart position of player upon contacting Ghoul.
			pc.position = new Vector3 (0, 0, 0);
			lives -= 1;
			UpdateLives ();
		}
	}

	// Functions to update UI.

	void UpdateScore () {
		scoreDisplay.text = "Score: " + score;
	}

	void UpdateLives () {
		livesDisplay.text = "Lives: " + lives;
	}
}
