using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HelpMenu : MonoBehaviour {
	
	//variables
	public Canvas helpMenu;
	public GameObject pathogen; 
	
	// Use this for initialization
	void Start () {
		helpMenu.GetComponent<Canvas> ();
		pathogen.GetComponent<GameObject> ();
	}
	
	//click the "no" button on the exit menu
	public void LaunchMainMenu()
	{
		pathogen.SetActive (true);
		helpMenu.enabled = false;
	}
}
