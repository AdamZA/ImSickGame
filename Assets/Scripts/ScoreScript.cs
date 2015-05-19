using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	public int score = 0;
	public Transform scoreBar;
	public int cellstowin = 4;
	public string nextlevel;

	// Use this for initialization
	void Start () 
	{
		score = 0;
		scoreBar.localScale = new Vector3 (0.0f, 0.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if( scoreBar.localScale.x < (score * 1.0f / cellstowin * 6.0f))
		{
			scoreBar.localScale = new Vector3 (scoreBar.localScale.x + 0.05f, 0.01f, 0.2f);
		}


		if(score >= cellstowin)
		{
			Application.LoadLevel(nextlevel);
		}
	}

	public void addScore()
	{
		score = score + 1;

	}
}
