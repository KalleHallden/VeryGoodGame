﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
	public static int scoreValue = 0;
	public static int level = 0;
	public static float speed;
	Text score;
    // Start is called before the first frame update
    void Start()
    {
    	speed = 2f;
        score = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + scoreValue;
    }
}
