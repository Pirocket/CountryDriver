using UnityEngine;
using System.Collections;

public class CollisionThings : MonoBehaviour {

	public AudioClip shootSound;
	private AudioSource source;

	private float vol = .5f;


	void OnCollisionEnter(Collision collisionInfo)
	{
		if(collisionInfo.collider.name == "opp1")
		{
			source.PlayOneShot(shootSound,vol);
			Application.LoadLevel ("GameOver");
		}
		else if(collisionInfo.collider.name == "opp2")
		{
			source.PlayOneShot(shootSound,vol);
			Application.LoadLevel ("GameOver");
		}

		else if (collisionInfo.collider.name == "right-barrier")
		{
			print("Right Barrier hit by car");
		}
		else if (collisionInfo.collider.name == "left-barrier")
		{
			print("Left Barrier hit by car");
		}

	}

	void Awake () {
		
		source = GetComponent<AudioSource>();
		
	}
}
