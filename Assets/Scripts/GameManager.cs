using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static bool gameEnd = false;

	public  GameObject completeLevelUi;

	public  GameObject gameoverUi;
	public  GameObject score;

	public static int completedLevel;

	public static bool isFirstTime = true;

    private void Start() {
		//PlayerPrefs.SetInt("LevelComplete",4);
		if(isFirstTime == true){
			SceneManager.LoadScene(0);
		}
	}
	public void Complete(){
		completeLevelUi.SetActive(true);
		score.SetActive(false);
		
	}
	public void EndGame(){
		if(gameEnd == false){
			gameEnd = true;
			gameoverUi.SetActive(true);
          // Debug.Log("over");
		  // restart();
		}
	}

	// void restart(){
	// 	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	// }

}
