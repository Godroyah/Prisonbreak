using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MakeYourEscape()
    {
        SceneManager.LoadScene("PrisonBreak - Final");
    }

    public void PlanYourBreakOut()
    {
        SceneManager.LoadScene("Controls");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void TurnYourselfIn()
    {
        Application.Quit();
    }
}
