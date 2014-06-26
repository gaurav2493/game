using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	// Use this for initialization
	public Transform player;
	public float cameraDistanceY;
	public float cameraDistanceZ;

	private GameObject[] gameObjects;

	private string text="";
	private bool onetime=true;

	void Update () {	
		transform.position = new Vector3 (player.position.x+4,cameraDistanceY,cameraDistanceZ);
	}
}
