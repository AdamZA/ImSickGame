using UnityEngine;
using System.Collections;

public class cellDestroyScript : MonoBehaviour 
{
	public GameObject cellObject;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	//basic collision script
	void OnCollisionEnter(Collision c)
	{
		if(c.gameObject.tag.Equals("Player"))
			Destroy (gameObject);
	}

}