using UnityEngine;
using System.Collections;

public class ShrinkScript : MonoBehaviour 
{
	public Transform pathogen;
	public Transform cameraPos;
	public float size; //just follow the size of like, one of the sides
	public float zoomcount = 1.0f;
	public float shrinkAmount = 0.25f;
	public int shrinkCounter = 0;

	// Use this for initialization
	void Start () 
	{
		size = 1;
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
		zoomcount = zoomcount + 0.8f;
		shrinkAmount = shrinkAmount - 0.05f;
		shrinkCounter = shrinkCounter + 1;
		if (shrinkCounter == 4)
			Application.LoadLevel ("Loss");
	}
}
