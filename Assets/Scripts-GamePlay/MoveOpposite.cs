using UnityEngine;
using System.Collections;


public class MoveOpposite : MonoBehaviour {


	public static float posn = OppositeCars.posn;

	int mspeed = 25;


	void Start()
	{
		
		transform.position = new Vector3(30, .57f, posn);
		
	}

	// Update is called once per frame
	void Update () {


		// the born opposite car is moved to this position

		transform.position = Vector3.MoveTowards(transform.position, new Vector3(-20, .57f, posn), 
		                                         mspeed  * Time.deltaTime);


		if (transform.position.x == -20) { 

			posn = OppositeCars.posn;
			
			transform.position =new Vector3(30, .57f, posn);
			
			transform.position = Vector3.MoveTowards(transform.position, new Vector3(-20, .57f, posn), 
			                                         mspeed  * Time.deltaTime);
			
		}
		
	}
}
