using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	public int score = 0;
	public Transform scoreBar;
	public int cellstowin = 4;
	public string nextlevel;
	public TextMesh scoreText;
	public TextMesh LevelText;
	public TextMesh tapText;
	public GameObject tapArea;

	// Use this for initialization
	void Start () 
	{
		score = 0;
		scoreBar.localScale = new Vector3 (0.0f, 0.0f, 0.0f);
		scoreText = GameObject.Find ("ScoreText").GetComponent<TextMesh>();
		LevelText = GameObject.Find ("LevelText").GetComponent<TextMesh>();
		tapText = GameObject.Find ("tapText").GetComponent<TextMesh>();
		scoreText.text = "Cells Absorbed: " + score + "/" + cellstowin;
		tapArea = GameObject.Find ("TapArea");
		tapArea.SetActive (false);
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
			//AutoFade.LoadLevel (nextlevel, 1,1,Color.black);
			tapArea.SetActive (true);
			LevelText.text = "";
			scoreBar.GetComponent<Animator>().enabled = true;
			if(nextlevel.Equals ("Victory"))
				tapText.text = "Tap here to finish your infection!";
			else
				tapText.text = "Tap here to move to the next level!";
		}

	}

	public void addScore()
	{
		if(score < cellstowin)
			score = score + 1;
		scoreText.text = "Cells Absorbed: " + score + "/" + cellstowin;
	}

	public void loadNext()
	{
		AutoFade.LoadLevel (nextlevel, 1,1,Color.black);

	}


}
