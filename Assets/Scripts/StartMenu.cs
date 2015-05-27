using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartMenu : MonoBehaviour {

	//variables
	public Canvas exitMenu;
	public Canvas helpMenu;
	public Button exitButton;

	//more button
	public Button moreButton;
	public Canvas moreCanvas;
	public Button soundButton;
	public Button musicButton;
	public Button helpButton;

	public GameObject pathogen; 
	public Button tapArea; 

	public int muteSounds;
	public int muteMusic;

	public AudioSource music;

	public Sprite musicIcon;
	public Sprite musicIconOFF;
	public Sprite soundIcon;
	public Sprite soundIconOFF;



	// Use this for initialization
	public void Start () {
		exitMenu.gameObject.SetActive(false);
		helpMenu.gameObject.SetActive(false);
		moreCanvas.gameObject.SetActive (false);
		music = GameObject.Find("Music").GetComponent<AudioSource>();

		muteSounds = PlayerPrefs.GetInt ("sounds");
		muteMusic = PlayerPrefs.GetInt ("music");
		
		if (muteMusic == 1)
		{
			music.mute = true;
			musicButton.image.sprite = musicIconOFF;
		}
		if (muteSounds == 1)
		{
			music.mute = true;
			soundButton.image.sprite = soundIconOFF;
		}
	}

	public void MoreClick()
	{
		Debug.Log (moreCanvas.isActiveAndEnabled);
		moreCanvas.gameObject.SetActive (!moreCanvas.isActiveAndEnabled);
	}

	//click the "exit" button on the start menu
	public void LaunchExitMenu()
	{
//		this.GetComponent<Canvas>().enabled = false;
		pathogen.SetActive (false);
		exitMenu.gameObject.SetActive(true);
	}

	//click the "exit" button on the start menu
	public void LaunchHelpMenu()
	{
//		pathogen.SetActive (false);
		helpMenu.gameObject.SetActive(true);		
		this.GetComponent<Canvas>().gameObject.SetActive(false);
	}

	//
	public void ReturnToBeginningStart()
	{
		Application.LoadLevel ("MainMenu");
	}

	//starting game
	public void StartGame()
	{
		Application.LoadLevel ("Level1");
	}

	public void StartTutorial()
	{
		Application.LoadLevel ("Tutorial");
	}

	public void MuteSoundsFunc ()
	{
		//update prefs
		
		if(PlayerPrefs.GetInt("sounds") == 1)
		{
			PlayerPrefs.SetInt ("sounds", 0);
			muteSounds = 0;
			soundButton.image.sprite = soundIcon;
		}
		else {
			PlayerPrefs.SetInt("sounds", 1);
			muteSounds = 1;
			soundButton.image.sprite = soundIconOFF;
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
			musicButton.image.sprite = musicIcon;
		}
		else {
			PlayerPrefs.SetInt("music", 1);
			muteMusic = 1;
			music.mute = true;
			musicButton.image.sprite = musicIconOFF;
		}
	}


}
