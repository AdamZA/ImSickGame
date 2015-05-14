using UnityEngine;
using System.Collections;

public class RandomMovement : MonoBehaviour {

	public float thrust;
	private Rigidbody rb;
	private int time=1;
	private Vector3 pos;

	// Use this for initialization
	void Start () {
		// Force object to be at y = 0
		pos = transform.position;
		pos.y = 0f;
		transform.position = pos;
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		time++;
		MoveRandomly ();
		pos = transform.position;
		pos.y = 0f;
		transform.position = pos;
		if (rb.velocity.magnitude > 1.5f)
			rb.velocity = new Vector3 ();
	}

	void MoveRandomly() {
		if (time == 5) {
			Vector3 randomMove = Random.insideUnitSphere * 5;
			rb.AddForce (randomMove*thrust);
			time = 1;
		}
	}
}
