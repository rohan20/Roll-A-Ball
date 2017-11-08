using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {

		//offset = camera position - player position
		offset = transform.position - player.transform.position;

	}
	
	// LateUpdate runs every frame just like Update but it runs after all items 
	// have been processed in the update.
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	} 
}
