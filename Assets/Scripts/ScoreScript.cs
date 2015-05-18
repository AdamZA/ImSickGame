using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	public int score;
	public Transform scoreBar;
	private int cellstowin = 4;

	// Use this for initialization
	void Start () 
	{
		score = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		scoreBar.localScale = new Vector3 (score * 1.0f / cellstowin * 6.0f, 0.001f, 0.2f);

		if(score >= cellstowin)
		{
			Application.LoadLevel("Level2");
		}
	}

	public void addScore()
	{
		score = score + 1;

	}
}
