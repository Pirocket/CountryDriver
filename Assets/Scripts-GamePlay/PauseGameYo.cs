using UnityEngine;
using System.Collections;

public class PauseGameYo : MonoBehaviour {


	GameObject soundObject;
	GameObject soundObject2;
	
	AudioSource audioSource;
	AudioSource audioSource2;

	string muteSoundValueCheck;


	public void GamePauseyoyo(){	

		// For pause/Play of Sound

		/* 
		   All these Play of sound codes, you need to write in MenuFunc.cs to Start sound again after
		   Pressing 'RESUME'button. 
		*/

		// Fetches engine sound attached to Main Camera object
		soundObject = GameObject.Find("Camera");
		audioSource = soundObject.GetComponent<AudioSource>();

		// Fetches Car Dash sound attached to 'car-control-cube' object 
		soundObject2 = GameObject.Find("car-control-cube");
		audioSource2 = soundObject.GetComponent<AudioSource>();
			

		// if game is running

		if (Time.timeScale == 1) {

			// Pauses the game
			Time.timeScale = 0;
			Debug.Log(Time.timeScale);
			pauseSound();

		}

		// else if game is paused

		else if (Time.timeScale == 0) {
			
			// Resumes to play the game
			Time.timeScale = 1;
			Debug.Log(Time.timeScale);

			string muteSoundValueCheck2 = PlayerPrefs.GetString("SoundValue") ;	

			Debug.Log (muteSoundValueCheck2);

			if (muteSoundValueCheck2 != "mute") {
				
				playSound();
				
			}


			
		}
	
	}

	void playSound(){

		// Resumes to play the sound
		audioSource.Play();
		audioSource2.Play();
	
	}

	void pauseSound(){
	
		// Pauses the sound
		audioSource.Pause();
		audioSource2.Pause();

	}


	void Start(){
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

			pauseSound();
			
		}
		
	}
	
	
}
