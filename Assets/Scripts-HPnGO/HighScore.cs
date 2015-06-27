using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		int scoree1 = PlayerPrefs.GetInt("HighScore");
		
		GetComponent<TextMesh>().text = "Your High Score is " + scoree1;
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
