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
//	public Button soundButton;
//	public Button musicButton;
	public Button helpButton;

	public GameObject pathogen; 
	public Button tapArea; 

	// Use this for initialization
	void Start () {
		exitMenu.GetComponent<Canvas> ();
		helpMenu.GetComponent<Canvas> ();
		exitButton.GetComponent<Button> ();

		exitMenu.enabled = false;
		helpMenu.enabled = false;

		//more button
		moreButton.GetComponent<Button> ();
		helpButton.GetComponent<Button> ();
		moreCanvas.GetComponent<Canvas> ();
		moreCanvas.gameObject.SetActive (false);

		pathogen.GetComponent<GameObject> ();
		tapArea.GetComponent<Button> ();
		
	}

	public void MoreClick()
	{
		if (moreCanvas.isActiveAndEnabled) {
			moreCanvas.gameObject.SetActive (false);
			
		} else {
			moreCanvas.gameObject.SetActive (true);
		}
	}

	//click the "exit" button on the start menu
	public void LaunchExitMenu()
	{
		pathogen.SetActive (false);
		exitMenu.enabled = true;
	}

	//click the "exit" button on the start menu
	public void LaunchHelpMenu()
	{
		pathogen.SetActive (false);
		helpMenu.enabled = true;
	}

	//
	public void LaunchChooseMenu()
	{
//		Application.LoadLevel (1);
	}

	//starting game
	public void StartGame()
	{
		Application.LoadLevel (1);
	}


}
