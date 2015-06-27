using UnityEngine;
using System.Collections;


public class OppositeCars : MonoBehaviour {

	public static float posn;

	public static float posn2;

	int rand ;

	GameObject soundObject;
	GameObject soundObject2;
	
	AudioSource audioSource;
	AudioSource audioSource2;
	
	string muteSoundValueCheck;

	// Use this for initialization
	void Start () {
	
		InvokeRepeating("CreateMyInstance", 1.0f, 1.0f);

		// Checks the value of muteSound that is set on Home Screen page via the mute sound button.
		muteSoundValueCheck = PlayerPrefs.GetString("SoundValue") ;	
		
		// Debug.Log(muteSoundValueCheck);
		
		// Fetches engine sound attached to Main Camera object
		soundObject = GameObject.Find("Camera");
		audioSource = soundObject.GetComponent<AudioSource>();
		
		// Fetches Car Dash sound attached to 'car-control-cube' object 
		soundObject2 = GameObject.Find("car-control-cube");
		audioSource2 = soundObject.GetComponent<AudioSource>();
		
		if (muteSoundValueCheck == "mute") {
			
			audioSource.Pause();
			audioSource2.Pause();
			
		}


	}

	void CreateMyInstance()
	{

		rand = Random.Range(1, 4); // generates a random number between 1 and 3.
		
		
		if (rand == 1) {
			posn = 1.6f;
			posn2 = 0;
		}
		
		else if (rand == 2) {
			posn = 0;
			posn2 = -1.6f;
		}
		
		else if (rand == 3) {
			posn = -1.6f;
			posn2 = 1.6f;
		}
		
		// Debug.Log(rand);

	}


}
