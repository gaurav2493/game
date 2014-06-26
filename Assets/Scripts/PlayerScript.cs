using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {


	private Vector3 fingerPos;

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("collided");	
		//Application.LoadLevel (Application.loadedLevel);
	}

}
