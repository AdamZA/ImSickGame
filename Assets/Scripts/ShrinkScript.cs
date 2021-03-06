﻿using UnityEngine;
using System.Collections;

public class ShrinkScript : MonoBehaviour 
{
	public Transform pathogen;
	public Transform cameraPos;
	public float size; //just follow the size of like, one of the sides
	private float zoomcount = 0.5f;
	private float shrinkAmount = 0.0f;
	public int shrinkCounter = 0;
	public TextMesh lives;

	// Use this for initialization
	void Start () 
	{
		size = 1;
		lives = GameObject.Find ("Lives").GetComponent<TextMesh>();
		lives.text = "Lives left: 3";
	}
	
	// Update is called once per frame
	void Update () 
	{
		if( pathogen.localScale.x > (size))
		{
			pathogen.localScale = new Vector3 (pathogen.localScale.x - 0.01f, pathogen.localScale.y - 0.01f, pathogen.localScale.z - 0.01f);
		}
	}

	public void shrink()
	{
		size = size - shrinkAmount;
		cameraPos.position = new Vector3 (cameraPos.position.x, cameraPos.position.y - zoomcount, cameraPos.position.z);
		//zoomcount = zoomcount + 0.15f;
		//shrinkAmount = shrinkAmount - 0.05f;
		shrinkCounter = shrinkCounter + 1;
		lives.text = "Lives left: " + (3 - shrinkCounter);
		pathogen.transform.position = new Vector3 (pathogen.transform.position.x, 0.0f, pathogen.transform.position.z);


		if (shrinkCounter == 4)
		{
			lives.text = "Dead";
			Application.LoadLevel ("Loss");
		}
	}
}
