using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    // Start is called before the first frame update
    Text highestScore;
    public static int highScore;
    void Start()
    {
        highestScore = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        highestScore.text = "" + highScore;
    }
}
