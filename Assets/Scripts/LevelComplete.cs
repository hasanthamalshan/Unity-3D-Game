using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LevelComplete : MonoBehaviour {

	public Button restartButton;
	public Button menuButton;
	
	// Use this for initialization
	public void restart(){
		
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	public void menu(){
		SceneManager.LoadScene(0);
	}
}
