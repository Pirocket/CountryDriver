using UnityEngine;
using System.Collections;

public class ButnDoSmthng : MonoBehaviour {

	int rand ;
	string muteSoundValue;
	int counter;

	GameObject PauseButton;


	// HP means Home Page.

	void Start()
	{
		muteSoundValue = PlayerPrefs.GetString("SoundValue") ;
		if (muteSoundValue == "mute") {
			
			PauseButton = GameObject.Find("PauseSound");
			PauseButton.SetActive (false);
			
		}
	}


	public void HPPlay () {	

		rand = Random.Range(1, 3);
		
		if (rand == 1) {
			Application.LoadLevel ("scene1");
		}
		
		else if (rand == 2) {
			Application.LoadLevel ("scene2");
		}
	     
					
	}

	public void HPSeeSettings () {	

		// This function is for 'Credits' button.
		Application.LoadLevel ("Credits");
				
	}

	public void HPSeeHighScore () {		
		Application.LoadLevel ("HighScore");
				
	}

	public void HPDoGameQuit () {		
		
		Application.Quit();	 // works in built apps. doesn't work when playing in unity editor
	}



	// GO means Game Over.


	public void GOPlayAgain () {		

		rand = Random.Range(1, 3);
		
		if (rand == 1) {
			Application.LoadLevel ("scene1");
		}
		
		else if (rand == 2) {
			Application.LoadLevel ("scene2");
		}
		
	}
	
	public void GOGoBack () {		
		
		Application.LoadLevel ("HomePage");
		
	}

	public void HPSoundMuteOn () {		

		PlayerPrefs.SetString ("SoundValue", "mute");

		GameObject PauseButton = GameObject.Find("PauseSound");
		PauseButton.SetActive (false);
		
	}



}
