using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
  [SerializeField] 
  public GameObject food;
  private float speed = 2f;
  private int counter = 0;
  private static float level = 1f;
  private static int shouldAddFood;
  private bool addedFirst;
 
  // Update is called once per frame
  void Update ()
  {
  	if (Time.timeScale != 0) 
  	{
  	if (counter == 100 && !addedFirst) {
  		shouldAddFood = Random.Range(0,10);
  		if (shouldAddFood < 3) {
  			Instantiate(food, new Vector3(11, Random.Range(-2, 3), 0), Quaternion.identity);
  		}
  		addedFirst = true;
  	}
  	if (counter >  500 / ScoreScript.speed) {
  		shouldAddFood = Random.Range(0,10);
  		if (shouldAddFood < 3) {
  			Instantiate(food, new Vector3(11, Random.Range(-2, 3), 0), Quaternion.identity);
  		}
  		counter = 1;
  	} else {
  		counter += 1;
  	}

  	}
  }
}
