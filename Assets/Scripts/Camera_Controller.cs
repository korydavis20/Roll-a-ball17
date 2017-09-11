using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;

	}
	
	// Update is called once per frame
	//LateUpdate will run after all the items have been processed when the player moves
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
