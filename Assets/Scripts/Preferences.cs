using UnityEngine;
using System.Collections;

public class Preferences : MonoBehaviour 
{

	int musicMuted; 
	int gameMuted; 

	public AudioSource music;

	// Use this for initialization
	void Start () 
	{
		musicMuted = PlayerPrefs.GetInt("music");
		gameMuted = PlayerPrefs.GetInt ("sounds");
		music = GameObject.Find ("Music").GetComponent<AudioSource> ();

		if(musicMuted == null)
		{
			PlayerPrefs.SetInt ("music", 0);
		}
		else if(musicMuted == 1)
		{
			music.mute = true;
		}

		if(gameMuted == null)
		{
			PlayerPrefs.SetInt ("sounds", 0);
		}


	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}


}
