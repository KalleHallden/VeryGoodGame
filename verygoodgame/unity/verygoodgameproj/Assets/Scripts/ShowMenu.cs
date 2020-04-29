using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;
    private bool menuIsOpen;
    void Start()
    {
       // Instantiate(menu, new Vector3(0, 0, 0), Quaternion.identity);
       // Debug.Log("Created Menu!");
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
    	if (Time.timeScale == 0 && !menuIsOpen) {
    		menuIsOpen = true;
    		menu = Instantiate(menu, new Vector3(0, 0, 0), Quaternion.identity);
        	Debug.Log("Created Menu!");
    	} else if (Time.timeScale == 1 && menuIsOpen) {
    		menuIsOpen = false;
    		Debug.Log("Destroy menu");
    		Destroy(menu);
    	}
    }
}
