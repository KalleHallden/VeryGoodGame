using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
	// Movement speed
	public float speed = 2;
    private bool ate = false;
    public GameObject tailPrefab;
    public static GameObject tail;
    static List<GameObject> snakeParts = new List<GameObject>();
    private Vector2 lastLocation;
    public static int snakeLength = 1;

	// force
	public float force = 200;

    // Start is called before the first frame update
    void Start()
    {
        // GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        snakeParts = new List<GameObject>();
        snakeParts.Add(gameObject);
        snakeLength = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // fly
        if (Input.GetKeyDown(KeyCode.Space))
        	GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        if (ate) {
           GameObject g = Instantiate(tailPrefab, new Vector3(snakeParts[snakeLength - 1].transform.position.x, snakeParts[snakeLength - 1].transform.position.y, 0f), Quaternion.identity);
           snakeParts.Add(g);
           snakeLength += 1;
           ate = false;
        }

        lastLocation = gameObject.transform.position;
        if (snakeLength != 0) {
            foreach (GameObject part in snakeParts)
        {
            if (part != gameObject) {
                 var newPosition = new Vector2(lastLocation.x - 1, lastLocation.y);
                lastLocation = part.transform.position;
                part.transform.position = newPosition;
            }
 
        }
        }
    }

    public static void removeTail() {
        tail = snakeParts[snakeLength -1];
        snakeParts.RemoveAt(snakeLength -1);
        snakeLength -= 1;
        Destroy(tail);
    }

    void OnCollisionEnter2D(Collision2D coll) {
    	// Collision logic
        if (coll.gameObject.name.StartsWith("FoodPrefab")) {
            ate = true;
            Destroy(coll.gameObject);
            Debug.Log("EATING!");
        }
    }
}


     
     
     
