using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailFollow : MonoBehaviour
{
    GameObject main;
    void Update()
    {
    	main = GameObject.Find("Character");
    	//transform.position.y = main.transform.position.y -1;
       // transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

      void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}