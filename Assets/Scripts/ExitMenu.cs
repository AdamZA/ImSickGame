using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ExitMenu : MonoBehaviour {

	//variables
	public Canvas exitMenu;
	public Button yesButton;
	public Button noButton;
	
	public GameObject pathogen; 
	public Button tapArea; 

	// Use this for initialization
	void Start () {
		exitMenu.GetComponent<Canvas> ();
		yesButton.GetComponent<Button> ();
		pathogen.GetComponent<GameObject> ();
		tapArea.GetComponent<Button> ();
	}

	//click the "no" button on the exit menu
	public void LaunchMainMenu()
	{
		pathogen.SetActive (true);
		exitMenu.gameObject.SetActive(false);
	}
	
	//quitting game
	public void ExitGame()
	{
		Application.Quit();
	}
}
