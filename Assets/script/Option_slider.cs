using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Option_slider : MonoBehaviour {

	public Slider slider;
	public Text text;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		text.text = slider.value.ToString();
	}
}
