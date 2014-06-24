using UnityEngine;
using System.Collections;

public class TouchTemp : MonoBehaviour {

	// Use this for initialization
	void Update () {
		if (Input.touchCount > 0 ) 
		{
			Ray ray = Camera.main.ScreenPointToRay( Input.GetTouch(0).position );
			RaycastHit hit;

			//Debug.Log("------"+hit.collider.transform.tag);
				Debug.Log("------"+hit.collider.gameObject.tag);
			
			if ( Physics.Raycast(ray, out hit) && hit.collider.tag == "redButton")
			{
				Debug.Log("hello"); 
			}
		}
	}
}
