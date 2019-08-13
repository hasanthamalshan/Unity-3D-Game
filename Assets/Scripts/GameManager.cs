using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static bool gameEnd = false;

	public GameObject completeLevelUi;
	public GameObject score;
	public void Complete(){
		completeLevelUi.SetActive(true);
		score.SetActive(false);
		
	}
	public void EndGame(){
		if(gameEnd == false){
			gameEnd = true;
           Debug.Log("over");
		  // restart();
		}
	}

	void restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
