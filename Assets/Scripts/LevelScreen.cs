using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text;
using UnityEngine;

public class LevelScreen : MonoBehaviour {
	public Button Button;

	// Use this for initialization
	void Start () {
		GameManager.isFirstTime = false;
		int  l = PlayerPrefs.GetInt("LevelComplete");

		for (int i = 1; i < 10;i++){
			if((Button.tag == ("level"+i.ToString())) && i > l){
				//Debug.Log(button.name);
				Button.interactable = false;
				// Debug.Log(button.tag);
				// Debug.Log("level"+i.ToString());
			}
		}
	}	
	
	// Update is called once per frame
	public void gotolevel(){
	   // Debug.Log(Int32.Parse(Button.name) + 1);
		SceneManager.LoadScene(Int32.Parse(Button.name) + 1);
	}

	
}
