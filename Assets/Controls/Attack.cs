using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {

	public GameObject projectile;
	public Transform front;
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			Debug.Log ("Pressed left click.");
			Instantiate (projectile, front.position, front.rotation);

		}
	}
}
