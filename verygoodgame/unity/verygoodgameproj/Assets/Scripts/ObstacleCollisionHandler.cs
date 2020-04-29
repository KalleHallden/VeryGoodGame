using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollisionHandler : MonoBehaviour
{
	private bool hasEntered;
	void OnTriggerEnter2D(Collider2D other) {
		if (!other.gameObject.name.StartsWith("TailPrefab") && !hasEntered) {
			hasEntered = true;
			if (Character.snakeLength == 1) {
				// Game Over
					SceneManager.LoadScene(0);
					if (ScoreScript.scoreValue > HighScore.highScore) {
						HighScore.highScore = ScoreScript.scoreValue;
					}
		    		ScoreScript.scoreValue = 0;
		    		Time.timeScale = 0;
			}
			else {
				Character.removeTail();
			}
		}
	}
}
