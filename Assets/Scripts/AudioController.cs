using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

	public static AudioController instance = null;
	private void Awake() {
		instance = this;
	}

	public AudioSource source;
	public AudioClip rollClip;
	public float volume = 1f;


	public void PlayRollSound() {
		source.PlayOneShot(rollClip, volume);
	}
}
