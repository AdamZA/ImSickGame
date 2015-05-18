using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed=4f;
	private int timer=0;


	// Use this for initialization
	void Start () {

	}

	void Update () {
		if (Input.touchCount > 0) {
			// The screen has been touched so store the touch
			Touch touch = Input.GetTouch(0);
			
			if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved) {
				// If the finger is on the screen, move the object smoothly to the touch position
				Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));                
				transform.position = Vector3.Lerp(-transform.position, touchPosition, Time.smoothDeltaTime);
			}
		}
		if (timer > 0) {
			timer--;
			if (timer==0) speed=4f;
		}
	}

	public void SpeedUp()
	{
		//increase the speed of the player
		speed=7.0f;
		timer=500;
	}
}
