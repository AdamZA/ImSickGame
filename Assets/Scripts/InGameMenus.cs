
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InGameMenus : MonoBehaviour {
	
	//variables
	public Canvas gameCanvas;
	public Canvas pauseCanvas;
	public Button pauseBtn;
	
	// Use this for initialization
	public void Start () {
		
		gameCanvas.GetComponent<Canvas> ();
		pauseCanvas.GetComponent<Canvas> ();
		gameCanvas.gameObject.SetActive(true);
		pauseCanvas.gameObject.SetActive(false);
	}

	public void LaunchPause (){
		pauseCanvas.gameObject.SetActive(true);
		gameCanvas.gameObject.SetActive(false);
	}
	
}
