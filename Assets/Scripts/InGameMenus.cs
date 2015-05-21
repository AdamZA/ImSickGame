
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InGameMenus : MonoBehaviour {
	
	//variables
	public Canvas gameCanvas;
	public Canvas moreCanvas;

	public Button pauseBtn;
	public Button playBtn;
	public Button backBtn;
	
	// Use this for initialization
	public void Start () {
		Time.timeScale = 1;
		gameCanvas.GetComponent<Canvas> ();
		gameCanvas.gameObject.SetActive(true);
		moreCanvas.gameObject.SetActive(false);

		pauseBtn.GetComponent<Button> ();
		playBtn.GetComponent<Button> ();
		backBtn.GetComponent<Button> ();

		playBtn.gameObject.SetActive(false);
		backBtn.gameObject.SetActive(false);
	}

	public void LaunchPause (){

		Time.timeScale = 0;

		//disable game
		pauseBtn.gameObject.SetActive(false);

		//enable pause
		playBtn.gameObject.SetActive(true);
		backBtn.gameObject.SetActive(true);
		gameCanvas.GetComponent<Image> ().enabled = true;
		moreCanvas.gameObject.SetActive(true);
	}

	public void LaunchPlay (){
		
		Time.timeScale = 1;

		//disable game
		pauseBtn.gameObject.SetActive(true);
		
		//enable pause
		playBtn.gameObject.SetActive(false);
		backBtn.gameObject.SetActive(false);
		gameCanvas.GetComponent<Image> ().enabled = false;
		moreCanvas.gameObject.SetActive(false);
	}
	
	public void ReturnToMainMenu()
	{
		Time.timeScale = 1;
		Application.LoadLevel ("MainMenu");
	}
	
}
