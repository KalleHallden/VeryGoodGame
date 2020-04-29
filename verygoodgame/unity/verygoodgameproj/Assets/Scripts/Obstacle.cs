using UnityEngine;
using System.Collections;
 
public class Obstacle : MonoBehaviour {
 
  [SerializeField] 
  public GameObject obstacle;
  public Transform obstPos;
  public bool start = true;
 
  // Update is called once per frame
  void Update ()
  {
  	if (start) {
  		Instantiate(obstacle, new Vector3(5, Random.Range(-2, 3), 0), Quaternion.identity);
  		start = false;
  	}
  
  }
}
