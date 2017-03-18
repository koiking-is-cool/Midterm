using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	public float moveSpeed;
	float mhorizontal = Input.GetAxis("Horizontal");
	float mvertical = Input.GetAxis("Vertical");

	// Use this for initialization
	void Start () {
		moveSpeed = 10f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (moveSpeed*mhorizontal*Time.deltaTime,0f,moveSpeed*mvertical*Time.deltaTime);
	}
}
