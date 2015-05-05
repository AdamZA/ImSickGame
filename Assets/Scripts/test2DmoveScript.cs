using UnityEngine;
using System.Collections;

public class test2DmoveScript : MonoBehaviour 
{
	//Class variables:
	public float moveSpeed = 2.0f;
	public Transform pathogenTransform; //reference to this object's transform, set in the Unity IDE

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		//Checks for WASD input, and moves in the appropriate direction. It will never move in the Y axes, except when moving between levels (maybe).
		if(Input.GetKey (KeyCode.A))
			pathogenTransform.Translate(moveSpeed * Time.deltaTime,0,0);

		else if(Input.GetKey (KeyCode.D))
			pathogenTransform.Translate(-moveSpeed * Time.deltaTime,0,0);

		if(Input.GetKey (KeyCode.S))
			pathogenTransform.Translate(0,0,moveSpeed * Time.deltaTime);

		else if(Input.GetKey (KeyCode.W))
			pathogenTransform.Translate(0,0,-moveSpeed * Time.deltaTime);

	}
}
