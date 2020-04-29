using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
		Button b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(delegate() { StartGame(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void StartGame() {
		Time.timeScale = 1;
		// Hide panels
	}
}
