using UnityEngine;
using System.Collections;

public class Bulletspeed : MonoBehaviour {
	public RaycastHit hit; //raycast hit info
	//Ray ray; //not needed anymore
	
	//Collider col; //not using anymore
	
	public float bSpeed = 10f; //speed of the bullet
	
	public float rSpeed = 0f; //bullet rotate speed
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		Vector3 fwd = transform.position; //faster way instead of typing it everytime, sets the location of the bullet
		Debug.DrawRay(transform.position, Vector3.forward); //draws a ray form the bullet to the right
		if (!Physics.Raycast(fwd, transform.forward, out hit,.65f)) //if not hitting something then
		{
			transform.Translate(Vector3.forward*bSpeed*Time.smoothDeltaTime); //move right * bSpeed * time.deltatime
		}
		else
		{
			
			if (hit.transform.gameObject.tag == "Ground") //if i hit an an object tagged as the ground
			{
				print("Hit Floor"); //prints hit ground in console
				Destroy(gameObject); //destroy myself
			}
			if (hit.transform.gameObject.tag == "Enemy") //if i hit an object tagged as an enemy
			{
				print("Hit Enemy"); //prints hit enemy in console
				Destroy(gameObject); //destroy myself
				Destroy(hit.collider.gameObject); //destroys the enemy i hit
			}
			if (hit.transform.gameObject.tag == "Mirror") //if i hit an object tagged as a mirror
			{
				print("Hit Mirror"); //prints hit mirror in console
				Debug.DrawRay(transform.position, Vector3.left); //reverses the ray direction
				transform.Rotate(Vector3.forward,180*rSpeed, Space.World); //rotates the bullet to move in the opposite direction
			}
			if (hit.transform.gameObject.tag == "Player") //if i hit an object tagged as a player
			{
				print("Hit Player"); //print hit player in the console
				Application.LoadLevel("testlose"); //load the lose level (will replace later)
			}
		}
	}
}