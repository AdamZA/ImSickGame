using UnityEngine;
using System.Collections;

public class cellDestroyScript : MonoBehaviour 
{
	public GameObject cellObject;
	public ParticleSystem deadPS;
	public AudioClip deadSound;

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
		if (c.gameObject.tag.Equals ("Player")) 
		{
			Transform pos = this.transform;


			if(this.tag.Equals ("Blood"))
			 {
				this.GetComponent<MeshCollider>().enabled = false;
				Instantiate(deadPS, new Vector3(pos.position.x, pos.position.y, pos.position.z), Quaternion.identity);
				this.GetComponent<Animator>().SetBool("dead", true);
				this.GetComponent<Rigidbody>().velocity = Vector3.zero;
				AudioSource.PlayClipAtPoint(deadSound, new Vector3(pos.position.x, pos.position.y, pos.position.z));
				Destroy(gameObject, 1.0f);	
			 }
			if(this.tag.Equals ("Antibody"))
			{
				this.GetComponent<SphereCollider>().enabled = false;
				this.GetComponent<Animator>().SetBool("dead", true);
				this.GetComponent<ChaseMovement>().enabled = false;
				Instantiate(deadPS, new Vector3(pos.position.x, pos.position.y, pos.position.z), Quaternion.identity);
				AudioSource.PlayClipAtPoint(deadSound, new Vector3(pos.position.x, pos.position.y, pos.position.z));
				Destroy(gameObject);	
			}
			if(this.tag.Equals ("SpeedUp"))
			{
				this.GetComponent<SphereCollider>().enabled = false;
				c.gameObject.GetComponent<test2DmoveScript>().SpeedUp();
				Instantiate(deadPS, new Vector3(pos.position.x, pos.position.y, pos.position.z), Quaternion.identity);
				this.GetComponent<Animator>().SetBool("dead", true);
				AudioSource.PlayClipAtPoint(deadSound, new Vector3(pos.position.x, pos.position.y, pos.position.z));
				Destroy(gameObject, 1.0f);
			}
		}
	}

}