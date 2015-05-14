using UnityEngine;
using System.Collections;

public class ChaseMovement : MonoBehaviour {

	public GameObject target;

	// Add a thrust force to push an object in its current forward direction
	public float thrust=70f;
	public float chaseFactor=4;
	private Rigidbody rb;
	private float distance;
	private Vector3 delta;
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
		distance = Vector3.Distance(target.transform.position, transform.position);
		if (distance < 3 && distance > 0.05) {
			Chase ();
		} else {
			MoveRandomly ();
		}
		pos = transform.position;
		pos.y = 0f;
		transform.position = pos;
	}

	void Chase() {
		delta = target.transform.position - transform.position;
		delta.Normalize();
		rb.AddForce (delta * thrust * chaseFactor*Time.deltaTime);
	}

	void MoveRandomly() {
		if (time == 7) {
			Vector3 randomMove = Random.insideUnitSphere;
			rb.AddForce (randomMove*thrust);
			time = 1;
		}
	}
}