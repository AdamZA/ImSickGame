using UnityEngine;
using System.Collections;

public class TutScript : MonoBehaviour 
{
	//Stuff
	public GameObject pathogen;

	public TextMesh tutText;
	public GameObject anti;
	public GameObject blood;
	public GameObject special;

	public GameObject blood1;
	public GameObject blood2;

	int textPos = 0;
	string[] tutorials = {"Hitting red blood cells will fill up the bar at the  top.\n\t\t\tIf you fill the bar you go to the next level.\n\t\t\t\t\t\t\tTap here to continue", "Hitting blue special cells give you a short speed boost.\n\t\t\tA timer at the top left shows how long it lasts.\n\t\t\t\t\t\t\tTap here to continue.","\t\t\t\tThe white antibodies will kill you.\n\t\t\t\tYou can see your lives at the  top left.\n\t\t\t\t\t\t\tTap here to continue.","\t\t  Press and hold on the screen to move around.\n\t\tLift and press again to change directions faster.\n\t\t\t\t\t\t\t\tTap here to continue", "Hit both of the red blood cells to end the tutorial!\n\t\t\t\t\t\t\t\t\tTap to begin."};

	// Use this for initialization
	void Start () 
	{
		pathogen.GetComponent<PlayerController> ().enabled = false;
		pathogen.GetComponent<test2DmoveScript> ().enabled = false;

		tutText = GameObject.Find ("TutText").GetComponent<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void tutTap()
	{

		if(textPos < tutorials.Length)
		{
			tutText.text = tutorials[textPos];
			textPos++;
		}
		else
		{
			tutText.text = "";
			pathogen.GetComponent<PlayerController> ().enabled = true;
			pathogen.GetComponent<test2DmoveScript> ().enabled = true;
		}

		if(textPos == 1)
		{
			blood.SetActive(true);
		}
		if(textPos == 2)
		{
			blood.SetActive(false);
			special.SetActive(true);
		}
		if(textPos == 3)
		{
			special.SetActive(false);
			anti.SetActive(true);
		}
		if(textPos == 4)
		{
			anti.SetActive(false);
		}
		if(textPos == 5)
		{
			blood1.SetActive(true);
			blood2.SetActive(true);
		}

	}
}
