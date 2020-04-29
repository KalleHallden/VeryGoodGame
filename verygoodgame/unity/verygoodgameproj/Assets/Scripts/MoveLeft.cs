using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour

{
	private bool hasPassed = false;
    // Update is called once per frame
    void Update()
    {
		transform.Translate(Vector3.left * Time.deltaTime * ScoreScript.speed);
		if (transform.position.x < -3 && !hasPassed) {
			ScoreScript.scoreValue += 1;
			hasPassed = true;
		} 
		if (transform.position.x < -14) {
			DestroyGameObject();
		}
		if (ScoreScript.scoreValue - ScoreScript.level >= 20) {
			ScoreScript.level = ScoreScript.scoreValue;
			ScoreScript.speed += 0.5f;
		}
       // transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

      void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}