//Alan Hsiao, Logic & Programming, Pool Audio Project, 11/18/15

using UnityEngine;
using System.Collections;

public class ColliderSound : MonoBehaviour {

	//declaring variable "audio"
	AudioSource audio;

	// Use this for initialization
	void Start() {
		//defining variable "audio" as audio source of game object attached to
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisonEnter(Collider other)
	{
		//if the object collides w/ an object of tag "RedBall"...
		if (other.gameObject.CompareTag ("RedBall"))
		{
			//...audio will play
			audio.Play();
		}
	}
}

//This is not working in the game. I don't know why not.