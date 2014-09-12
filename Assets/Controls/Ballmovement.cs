using UnityEngine;
using System.Collections;

public class Ballmovement : MonoBehaviour {
	
	public float xSpeed;
	public float zSpeed;
	private int xSign =1;
	private int zSign = 1;
	private int Score2=0;
	private int Score1=0;

	void Start()
	{
		while (Mathf.Abs (xSpeed)<2.0f) 
		{
			xSpeed = Random.Range (-8.0f, 8.0f);
		}
		while (Mathf.Abs (zSpeed)<2.0f) 
		{
			zSpeed = Random.Range (-8.0f, 8.0f);	
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "left Boundary")
		{
			Score2++;
			xSign = -1 * xSign;
			guiText.text =Score2.ToString ();

		}
		if (col.gameObject.name == "right Boundary")
		{
			Score1++;
			xSign = -1 * xSign;

		}
		if (col.gameObject.name == "Top boundary")
		{
			zSign = -1 * zSign;
		}
		if (col.gameObject.name == "Bottom boundary")
		{
			zSign = -1 * zSign;
		}
		if (col.gameObject.name== "Paddle")
		{

			xSign=-1*xSign;
		}

	}

	void Update () 
	{
		transform.Translate (xSign*xSpeed*Time.deltaTime, 0, zSign*zSpeed*Time.deltaTime);
	}
}
