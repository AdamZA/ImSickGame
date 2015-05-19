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

		exitMenu.gameObject.SetActive(false);
		helpMenu.gameObject.SetActive(false);

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
	public void LaunchChooseMenu()
	{
//		Application.LoadLevel (1);
	}

	//starting game
	public void StartGame()
	{
		Application.LoadLevel ("Level1");
	}


}
