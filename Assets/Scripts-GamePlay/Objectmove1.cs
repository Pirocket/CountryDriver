using UnityEngine;
using System.Collections;

public class Objectmove1 : MonoBehaviour
{
	public float moveSpeed = 10f;
	public float turnSpeed = 50f; // this hasn't been used in the script yes bt u cn use it.
	
	
	void Update ()
	{
		/* 
		 * there is some misconfigurations with direction keys with respect to the 
		 * direction of movement.
		 * 
		 * Its may be becoz I have imported the object in unity in wrong rotation values.
		 * 
		 * But the code below correctly moves the car for Country Driver game in correct direction 
		 * as per keys pressed.
		 * 
		 * Adjust the directions and keys for code below for other objects in future for 
		 * proper correct movement as per keys pressed if needed. 

		 */




		// moves the object forward 
		// if(Input.GetKey(KeyCode.UpArrow))
		// transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);


		// moves the object backward
		// if(Input.GetKey(KeyCode.DownArrow))
	    // transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);


		// moves the object rightward
		if(Input.GetKey(KeyCode.RightArrow))
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

		// moves the object leftward
		if(Input.GetKey(KeyCode.LeftArrow))
			transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
		
	}
}