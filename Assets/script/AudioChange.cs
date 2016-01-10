using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AudioChange : MonoBehaviour {
	public AudioSource audio;
	public AudioSource[] audio_se;
	public Slider slider;

	public void ChangeAudio(){
		audio.volume = slider.value * 0.1f;
	}

	public void ChangeAudio_SE(){
		for (int i = 0; i < audio_se.Length; ++i) {
			audio_se[i].volume = slider.value * 0.1f;
		}
	}
}
