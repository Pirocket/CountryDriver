using UnityEngine;
using System.Collections;

public class ScoreAndText : MonoBehaviour {

	// Use this for initialization

	int score = 0;

	void Start () {

		GetComponent<TextMesh>().text = "Hello World";

		StartCoroutine(ScoreCountYo());

	}

	IEnumerator ScoreCountYo()
	{
		while(true)
		{
		
			score++;

			PlayerPrefs.SetInt("score", score) ;


			if(PlayerPrefs.HasKey("HighScore")){
			
				int high = PlayerPrefs.GetInt("HighScore") ;

				// Debug.Log(high);

				if (score>high){

					PlayerPrefs.SetInt("HighScore", score) ;

				}
			}

			else{
			
				PlayerPrefs.SetInt("HighScore", score) ;

			}

			
			GetComponent<TextMesh>().text = "" + score;
			
			yield return new WaitForSeconds(2);
		}
	}

	
	// Update is called once per frame
	void Update () {


	
	}
}
