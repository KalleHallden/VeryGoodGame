using UnityEngine;
using System.Collections;
 
public class SpawnObstacle : MonoBehaviour {
 
  [SerializeField] 
  public GameObject obstacle;
  private float speed = 2f;
  private static int counter = 0;
  private static float level = 1f;
 
  // Update is called once per frame
  void Update ()
  {
  	if (Time.timeScale != 0) {
  		if (counter == 0) {
  			counter += 1;
  			Instantiate(obstacle, new Vector3(7, Random.Range(-2, 3), 0), Quaternion.identity);
  		}
  		if (counter > 500 / ScoreScript.speed) {
  			Instantiate(obstacle, new Vector3(7, Random.Range(-2, 3), 0), Quaternion.identity);
  			counter = 1;
  		} else {
  			counter += 1;
  		}
  	}
  }
}