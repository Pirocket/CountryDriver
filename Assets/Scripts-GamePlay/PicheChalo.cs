	using UnityEngine;
	using System.Collections;
	
	public class PicheChalo : MonoBehaviour {		
		
		
	public Vector3 position1 = new Vector3(200, -.5f, -35.8f);
	public Vector3 position2 = new Vector3(-10.29f, -.5f, -35.8f);	


	void Update(){

		transform.position = Vector3.MoveTowards(transform.position, 
		                                         position2, 28 * Time.deltaTime); 

		if (transform.position.x == -10.29f) { 

			transform.position = position1;

			transform.position = Vector3.MoveTowards(transform.position, 
			                                         position2, 28 * Time.deltaTime); 

		}

	}		

		
		
		
	}

