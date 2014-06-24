using UnityEngine;
using System.Collections;

public class GroundSpawnScript : MonoBehaviour {

	public Transform player;
	public float floorSpawnDistance=0;
	public Transform ground;

	private float groundLeftX=-3.071233f;
	// Update is called once per frame
	void Update () {
	
		if (player.position.x - groundLeftX > floorSpawnDistance) 
		{
			Instantiate (ground, new Vector3 (transform.position.x, -1.654969f, 0f), Quaternion.identity);
			groundLeftX = transform.position.x;
		}

	}
}
