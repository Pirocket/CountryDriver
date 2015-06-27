using UnityEngine;
using System.Collections;

public class GameOverScore : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int scoree = PlayerPrefs.GetInt("score");

		GetComponent<TextMesh>().text = "" + scoree;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
