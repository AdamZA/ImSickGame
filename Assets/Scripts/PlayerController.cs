using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed=500.0f;
	public int timeOfSpeedUp = 100;
	private int timer=0;
	private Vector3 delta;
	private Rigidbody rb;
	private Vector3 pos;
	public float speedUpBonus=100.0f;
	public TextMesh buffs;

	// Use this for initialization
	void Start () {
		pos = transform.position;
		pos.y = 0.45f;
		transform.position = pos;
		rb = GetComponent<Rigidbody> ();
		buffs = GameObject.Find ("Buffs").GetComponent<TextMesh>();
		buffs.text = "";
	}

	void Update () {
		if (Input.touchCount > 0) {
			// The screen has been touched so store the touch
			Touch touch = Input.GetTouch(0);
			
			if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved) {
				//
				// If the finger is on the screen, move the object smoothly to the touch position
				Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));  
				//Vector3 myTouchPosition = touch.position;
				delta = touchPosition - transform.position;
				delta.y=0f;
				delta.Normalize();
				rb.AddForce (delta * speed * Time.deltaTime);
				//Vector3 moveDirection = transform.position - touchPosition;
//				moveDirection.Normalize();
//				moveDirection.y = 10f;

				//transform.position = Vector3.Lerp(transform.position, touchPosition, Time.smoothDeltaTime);
//				this.gameObject.GetComponent<Rigidbody>().AddForce(touchPosition*speed);
			}
			pos = transform.position;
			pos.y = 0.45f;
			transform.position = pos;
		}
		if (timer > 0) 
		{
			timer--;
			buffs.text = "Speedup Left: " + timer/100.0f + "s";
			if (timer==0) 
			{
				speed-=speedUpBonus;
				buffs.text = "";
				Debug.Log("Speed up finished");
			}
		}
	}

	public void SpeedUp()
	{
		//increase the speed of the player
		speed+=speedUpBonus;
		timer=timeOfSpeedUp;
		buffs.text = "Speedup Left: " + timer + "ms";
	}
}
