using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour {

	public GameObject[] gameObjects;

	public float spawnMin=1f;
	public float spawnMax=3f;
	public float spawnDistance;

	private float targetDistance;

	void Start () {
		//targetDistance = transform.position.x + spawnDistance;
		Spawn ();
	}
	void Update()
	{
		if (transform.position.x > targetDistance) 
		{
			Spawn ();		
		}

	}

	private void Spawn()
	{
		Instantiate (gameObjects [Random.Range (0, gameObjects.GetLength (0))], new Vector3(transform.position.x+10,-3.2f,0), Quaternion.identity);
		targetDistance = transform.position.x + spawnDistance;
			//Invoke("Spawn",Random.Range(spawnMin,spawnMax));
	}
}
