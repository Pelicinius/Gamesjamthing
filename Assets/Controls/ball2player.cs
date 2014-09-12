using UnityEngine;
using System.Collections;

public class ball2player : MonoBehaviour {

	public float zSpeed =1.0f;
	// Update is called once per frame
	
	void Update () 
	{
		float z = transform.position.z;
		if(Input.GetKey(KeyCode.W))  
		{
			transform.Translate(0,0,zSpeed*Time.deltaTime);
			
		}
		
		if(Input.GetKey (KeyCode.S))
		{
			//move right
			transform.Translate(0,0,-zSpeed*Time.deltaTime);
		}
		
		
		z = Mathf.Clamp (transform.position.z, -3, 3);
		
		transform.position = new Vector3 (-5-1/2, 1, z);
	}
}
