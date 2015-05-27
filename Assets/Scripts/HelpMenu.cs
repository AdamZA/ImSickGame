using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HelpMenu : MonoBehaviour {
	
	//variables
	public Canvas startMenu;
	public Canvas moreCanvas;
	public Canvas currentMoreCanvas;
	public GameObject pathogen; 
	public Button backBtn;
	public Button moreBtn;
	
	public Button soundButton;
	public Button musicButton;
	public Sprite musicIcon;
	public Sprite musicIconOFF;
	public Sprite soundIcon;
	public Sprite soundIconOFF;
	public int muteSounds;
	public int muteMusic;
	
	public AudioSource music;

	// Use this for initialization
	void Start () {
		startMenu.GetComponent<Canvas> ();
		pathogen.GetComponent<GameObject> ();
		moreCanvas.GetComponent<Canvas> ();
		currentMoreCanvas.GetComponent<Canvas> ();
		moreCanvas.gameObject.SetActive (false);
		currentMoreCanvas.gameObject.SetActive (false);
//		backBtn.GetComponent<Button> ();


		music = GameObject.Find("Music").GetComponent<AudioSource>();
		
		muteSounds = PlayerPrefs.GetInt ("sounds");
		muteMusic = PlayerPrefs.GetInt ("music");
		
		if (muteMusic == 1)
			music.mute = true;
	}

	
	public void MoreClick()
	{
		Debug.Log (currentMoreCanvas.isActiveAndEnabled);
		currentMoreCanvas.gameObject.SetActive (!currentMoreCanvas.isActiveAndEnabled);
	}
	
	//click the "no" button on the exit menu
	public void LaunchMainMenu()
	{
		Debug.Log ("asfdf");		
//		pathogen.SetActive (true);
		startMenu.gameObject.SetActive (true);
		moreCanvas.gameObject.SetActive(false);
		currentMoreCanvas.gameObject.SetActive(false);
		this.GetComponent<Canvas>().gameObject.SetActive(false);
	}

	public void BackToMainMenu()
	{
		Application.LoadLevel ("MainMenu");
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
