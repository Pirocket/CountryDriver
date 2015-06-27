using UnityEngine;
using System.Collections;

public class MenuAppear : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
	
			if (Time.timeScale == 0) {
				
				this.GetComponent<Renderer>().enabled = true;				
			}

		else if (Time.timeScale == 1) {
			
			this.GetComponent<Renderer>().enabled = false;
			
		}			
			
		}

}



