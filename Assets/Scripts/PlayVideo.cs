using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(AudioSource))]

public class PlayVideo : MonoBehaviour {

	public MovieTexture movie;
	public AudioSource audio;

	// Use this for initialization
	void Start () {
		//GetComponent<RawImage> ().texture = movie as MovieTexture;
		//audio = GetComponent<AudioSource> ();
		//audio.clip = movie.audioClip;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void playVideo(){
		//movie.Play ();
	}
}
