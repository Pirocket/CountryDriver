using UnityEngine;
using System.Collections;


public class MoveOpposite2 : MonoBehaviour {
	
	
	public static float posn2 = OppositeCars.posn2;

	int mspeed = 25;


	void Start()
	{

		transform.position = new Vector3(30, .57f, posn2);

	}
	
	
	// Update is called once per frame
	void Update () {

		
		// the born opposite car is moved to this position	
		
		transform.position = Vector3.MoveTowards(transform.position, new Vector3(-20, .57f, posn2), 
		                                         mspeed  * Time.deltaTime);

		if (transform.position.x == -20) { 

			posn2 = OppositeCars.posn2;
			
			transform.position = new Vector3(30, .57f, posn2);
			
			transform.position = Vector3.MoveTowards(transform.position, new Vector3(-20, .57f, posn2), 
			                                         mspeed  * Time.deltaTime);
			
		}

		
	}
}
