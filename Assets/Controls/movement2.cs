using UnityEngine;
using System.Collections;

public class movement2 : MonoBehaviour 
{


	public float zSpeed =20.0f;
	public string direction;
	public float JumpSpeed= 100.0f;
	public GameObject jim;
	private float mouseX;
	private float mouseZ;
	private float pos;
	// Update is called once per frame

	void Update () 
	{

		HandleInput ();

	}

	void HandleInput() {

				Debug.Log (direction);
		
				if (Input.GetKey (KeyCode.W)) {
						transform.Translate (0, 0, zSpeed * Time.deltaTime);
						direction = "up";

				} else if (Input.GetKey (KeyCode.S)) {
						transform.Translate (0, 0, -zSpeed * Time.deltaTime);
						direction = "down";
				}

				if (Input.GetKey (KeyCode.A)) {
						transform.Translate (-zSpeed * Time.deltaTime, 0, 0);
						direction = "left";
				} else if (Input.GetKey (KeyCode.D)) {
						transform.Translate (zSpeed * Time.deltaTime, 0, 0);
						direction = "right";
				}
				if (Input.GetKeyUp (KeyCode.Space)) 
				{
					Jump ();
				}

		}
		
		void Jump()
		{
			rigidbody.AddForce(Vector3.up*JumpSpeed);
		}


	}

