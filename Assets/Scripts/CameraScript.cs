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

	void OnGUI()
	{
		GUI.Box(new Rect(Screen.width/2,Screen.height/2,200f,200f),"score"+text);
	}

	void Update () {
	
		transform.position = new Vector3 (player.position.x+1,cameraDistanceY,cameraDistanceZ);

		/*
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) 
		{
			Ray ray = Camera.main.ScreenPointToRay( Input.GetTouch(0).position );
			RaycastHit hit;


			
			if ( Physics.Raycast(ray, out hit))
			{
				if(onetime)
					text="press";
				else
					text="not ONetime"+hit.transform.tag;
				if( hit.collider.gameObject.tag.Equals( "redButton"))
				{
				DestroyAllObjects("redStick");
				}
				else if( hit.collider.gameObject.tag.Equals( "greenButton"))
				{
					DestroyAllObjects("greenStick");
				}
				else if( hit.collider.gameObject.tag.Equals( "yellowButton"))
				{
					DestroyAllObjects("yellowStick");
				}
			}

		}*/
	}
	private void DestroyAllObjects(string stickTag)
	{
		gameObjects = GameObject.FindGameObjectsWithTag (stickTag);
		
		for(var i = 0 ; i < gameObjects.Length ; i ++)
		{
			Destroy(gameObjects[i]);
		}
	}
}
