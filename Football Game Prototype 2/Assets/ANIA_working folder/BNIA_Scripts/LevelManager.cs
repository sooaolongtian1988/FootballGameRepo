using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OptionMenu()
    {
        SceneManager.LoadScene("OptionMenu");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Leaderboards()
    {
        SceneManager.LoadScene("Leaderboards");
    }


}
