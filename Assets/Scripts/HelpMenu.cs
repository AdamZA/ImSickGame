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

	// Use this for initialization
	void Start () {
		startMenu.GetComponent<Canvas> ();
		pathogen.GetComponent<GameObject> ();
		moreCanvas.GetComponent<Canvas> ();
		currentMoreCanvas.GetComponent<Canvas> ();
		moreCanvas.gameObject.SetActive (false);
		currentMoreCanvas.gameObject.SetActive (false);
//		backBtn.GetComponent<Button> ();
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
}
