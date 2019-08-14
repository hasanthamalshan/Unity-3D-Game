using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Start : MonoBehaviour {

	public void exit(){
		Application.Quit();
	}

	public void stratGame(){
		SceneManager.LoadScene(1);
	}
}
