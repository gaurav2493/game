using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {


	private Vector3 fingerPos;

	void OnTriggerEnter2D(Collider2D other)
	{
		Application.LoadLevel (1);
	}

	void Update()
	{
		if(transform.position.y<=-2f)
		{Application.LoadLevel(1);}
	}

}
