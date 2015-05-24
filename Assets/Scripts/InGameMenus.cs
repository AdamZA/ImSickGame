
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

	public int muteSounds;
	public int muteMusic;

	public AudioSource music;

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

		music = GameObject.Find("Music").GetComponent<AudioSource>();

		muteSounds = PlayerPrefs.GetInt ("sounds");
		muteMusic = PlayerPrefs.GetInt ("music");
		
		if (muteMusic == 1)
			music.mute = true;
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

	public void MuteSoundsFunc ()
	{
		//update prefs

		if(PlayerPrefs.GetInt("sounds") == 1)
		{
			PlayerPrefs.SetInt ("sounds", 0);
			muteSounds = 0;
		}
		else {
			PlayerPrefs.SetInt("sounds", 1);
			muteSounds = 1;
		}
	}

	public void MuteMusicFunc ()
	{
		//update prefs
		
		if(PlayerPrefs.GetInt("music") == 1)
		{
			PlayerPrefs.SetInt ("music", 0);
			muteMusic = 0;
			music.mute = false;
		}
		else {
			PlayerPrefs.SetInt("music", 1);
			muteMusic = 1;
			music.mute = true;
		}
	}
	
	public void ReturnToMainMenu()
	{
		Time.timeScale = 1;
		Application.LoadLevel ("MainMenu");
	}
	
}
