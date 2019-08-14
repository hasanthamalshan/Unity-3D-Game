using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {

	public Text score;
	public Transform player;

    private void Start() {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(GameManager.gameEnd == false)
		score.text = ((player.position.z-22f)/10).ToString("0");
	}
}
