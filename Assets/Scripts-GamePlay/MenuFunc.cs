using UnityEngine;
using System.Collections;

public class MenuFunc : MonoBehaviour {

	
	// Use this for initialization
	
	public Transform leftTrigger;
	public Transform rightTrigger;

	public GameObject soundObject;
	public GameObject soundObject2;
	
	public AudioSource audioSource;
	public AudioSource audioSource2;

	GameObject MenuResume;
	GameObject MenuQuit;
	



	void Start(){

		MenuResume = GameObject.Find("Menu-Resume");
		MenuQuit = GameObject.Find("Menu-Quit");
	
		// For pause/Play of Sound
		
		// Fetches engine sound attached to Main Camera object
		soundObject = GameObject.Find("Camera");
		audioSource = soundObject.GetComponent<AudioSource>();
		
		// Fetches Car Dash sound attached to 'car-control-cube' object 
		soundObject2 = GameObject.Find("car-control-cube");
		audioSource2 = soundObject.GetComponent<AudioSource>();
	
	}

	
	// Update is called once per frame
	void Update () {
		
		if (Time.timeScale == 0) {	
	
			
			if(Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer){
				if(Input.touchCount > 0) {
					checkTouch(Input.GetTouch(0).position);
					
				}
			}else if(Application.platform == RuntimePlatform.WindowsEditor){ // Else if Desktop
				if(Input.GetMouseButton(0)) {
					checkTouch(Input.mousePosition);
					
				}
			}
			
		}

	}	
	
	private void checkTouch( Vector2 pos ) {
		Ray ray = Camera.main.ScreenPointToRay( pos );
		RaycastHit hit;
		if(Physics.Raycast(ray, out hit)){
			if(hit.collider.transform  == leftTrigger) {
				ClickLeft();
			} else if(hit.collider.transform  == rightTrigger){
				ClickRight();
			}
		}
	}
	
	
	
	public void ClickLeft() { 


		
		Time.timeScale = 1;
		Debug.Log(Time.timeScale);

		// Checks the value of muteSound that is set on Home Screen page via the mute sound button.
		string muteSoundValueCheck = PlayerPrefs.GetString("SoundValue") ;	
		
		// Debug.Log(muteSoundValueCheck);
		
		// Fetches engine sound attached to Main Camera object
		soundObject = GameObject.Find("Camera");
		audioSource = soundObject.GetComponent<AudioSource>();
		
		// Fetches Car Dash sound attached to 'car-control-cube' object 
		soundObject2 = GameObject.Find("car-control-cube");
		audioSource2 = soundObject.GetComponent<AudioSource>();
		
		if (muteSoundValueCheck != "mute") {
			
			audioSource.Play();
			audioSource2.Play();
			
		}

		
	}
	
	public void ClickRight() {


		MenuResume.GetComponent<Renderer>().enabled = false;
		MenuQuit.GetComponent<Renderer>().enabled = false;
		
		Application.LoadLevel ("HomePage");
		
		
	}
}
