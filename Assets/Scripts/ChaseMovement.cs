using UnityEngine;
using System.Collections;

public class ChaseMovement : MonoBehaviour {

//	public Vector3 speed = new Vector2(10,0,10);
//
//	public Vector3 direction = new Vector2(-1,0,0);
//	
//	private Vector3 movement;
//
//	Vector3 rotation = Quaternion;
//	 radius = Vector3(5,0,0);
//	 currentRotation = 0.0;
//
//	// Update is called once per frame
//	void Update () {
//		// 2 - Movement
//		movement = new Vector3 (
//			speed.x * direction.x,
//			speed.z * direction.z);
//	}
//	
//	void FixedUpdate()
//	{
//		// Apply movement to the rigidbody
//		GetComponent<Rigidbody>().velocity = movement;
//	}
	public GameObject target;
	public float movementSpeed = 5f;
	public float rotationSpeed = 90f;
	
	private float currentAngle;
	private float targetAngle;
	
	// Use this for initialization
	void Start () {
		
		// Force object to be at z = 0
		Vector3 pos = transform.position;
		pos.z = 0f;
		transform.position = pos;
		
		currentAngle = GetAngleToTarget();
	}
	
	// Update is called once per frame
	void Update () {
		
		targetAngle = GetAngleToTarget();
		currentAngle = Mathf.MoveTowardsAngle(currentAngle, targetAngle, rotationSpeed * Time.deltaTime);
		transform.position += Quaternion.Euler(0,0,currentAngle) * Vector3.right * movementSpeed * Time.deltaTime;
		
	}
	
	float GetAngleToTarget()
	{
		Vector3 v3 = target.transform.position - transform.position;        
		return Mathf.Atan2(v3.y, v3.x) * Mathf.Rad2Deg;
	}

}