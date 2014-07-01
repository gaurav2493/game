using UnityEngine;

[RequireComponent(typeof(PlatformerCharacter2D))]
public class Platformer2DUserControl : MonoBehaviour 
{
	public static float speed=0.7f;
	private PlatformerCharacter2D character;
    //private bool jump;

	void Awake()
	{
		character = GetComponent<PlatformerCharacter2D>();
	}

  

	void FixedUpdate()
	{
		// Read the inputs.
		/*bool crouch = Input.GetKey(KeyCode.LeftControl);
		#if CROSS_PLATFORM_INPUT
		float h = CrossPlatformInput.GetAxis("Horizontal");
		#else
		float h = Input.GetAxis("Horizontal");
		#endif*/

		// Pass all parameters to the character control script.
		//character.Move( h, crouch , jump );
		character.Move( speed, false , JumpTouchScript.jump );

        // Reset the jump input once it has been used.
		JumpTouchScript.jump = false;
	}
}
