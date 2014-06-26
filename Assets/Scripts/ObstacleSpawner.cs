using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour {

	public GameObject[] gameObjects;

	public float spawnMin=1f;
	public float spawnMax=3f;

	void Start () {
		Spawn ();
	}
	private void Spawn()
	{
		Instantiate (gameObjects [Random.Range (0, gameObjects.GetLength (0))], new Vector3(transform.position.x,transform.position.y,0), Quaternion.identity);
		Invoke("Spawn",Random.Range(spawnMin,spawnMax));
	}
}
