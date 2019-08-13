using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float sidewaysforce = 100f;
	public float forwardforce = 1500f;
	public PlayerMovement movementPlay;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		rb.AddForce(0,0,forwardforce*Time.deltaTime);
			
		if(Input.GetKey("left")){
			rb.AddForce(-sidewaysforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
			}
		if(Input.GetKey("right")){
			rb.AddForce(sidewaysforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
			}

		if(rb.position.y < -1){
			FindObjectOfType<GameManager>().EndGame();
		}
	}

    private void OnCollisionEnter(Collision other) {
		if(other.collider.tag == "obstacle"){
			movementPlay.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
    
}
