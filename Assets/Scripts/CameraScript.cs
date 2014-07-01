using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	// Use this for initialization
	public Transform player;
	public Transform redButton;
	public Transform greenButton;
	public Transform yellowButton;

	public float cameraDistanceY;
	public float cameraDistanceZ;

	private GameObject[] gameObjects;

	private string text="";
	private bool onetime=true;

	private Vector3 greenPosition=new Vector3(0.1f,0.75f,5f);
	private Vector3 redPosition=new Vector3(0.1f,0.50f,5f);
	private Vector3 yellowPosition=new Vector3(0.1f,0.25f,5f);

	void Update () {	
		transform.position = new Vector3 (player.position.x+4f,cameraDistanceY,cameraDistanceZ);

		greenButton.position = camera.ViewportToWorldPoint (greenPosition);
		redButton.position = camera.ViewportToWorldPoint (redPosition);
		yellowButton.position = camera.ViewportToWorldPoint (yellowPosition);
	}
}
