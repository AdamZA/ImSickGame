using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HelpMenu : MonoBehaviour {
	
	//variables
	public Canvas startMenu;
	public Canvas moreCanvas;
	public GameObject pathogen; 
	public Button backBtn;

	
	// Use this for initialization
	void Start () {
		startMenu.GetComponent<Canvas> ();
		pathogen.GetComponent<GameObject> ();
//		backBtn.GetComponent<Button> ();
	}
	
	//click the "no" button on the exit menu
	public void LaunchMainMenu()
	{
		Debug.Log ("asfdf");		
//		pathogen.SetActive (true);
		startMenu.gameObject.SetActive (true);
		moreCanvas.gameObject.SetActive(false);
		this.GetComponent<Canvas>().gameObject.SetActive(false);
	}
}
