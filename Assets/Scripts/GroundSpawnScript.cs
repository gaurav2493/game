using UnityEngine;
using System.Collections;

public class GroundSpawnScript : MonoBehaviour {

	public Transform cameraTrans;
	public float floorSpawnDistance;
	public Transform ground;

	public float spawnMin=5f;
	public float spawnMax=7f;

	private float groundLeftX=-3.071233f;
	private float randomDistance;
	// Update is called once per frame
	void Update () {
	
		if (cameraTrans.position.x - groundLeftX > floorSpawnDistance) 
		{
			randomDistance=Random.Range(spawnMin,spawnMax);
			Debug.Log(randomDistance);
			Instantiate (ground, new Vector3 (transform.position.x+randomDistance, -1.654969f, 0f), Quaternion.identity);
			groundLeftX = transform.position.x+randomDistance;//-1.654969f
		}

	}
}
