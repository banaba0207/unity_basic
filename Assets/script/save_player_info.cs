using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class save_player_info : MonoBehaviour {

    public Text player_name_text;
    public InputField player_name_inputfield;

    public Toggle morning;
    public GameObject morning_on;
    public Toggle daytime;
    public GameObject daytime_on;
    public Toggle night;
    public GameObject night_on;

    public Text comment_text;
    public InputField comment_inputfield;

    void Start () {
        if(PlayerPrefs.HasKey("player_name")) {
            player_name_inputfield.text = PlayerPrefs.GetString ("Player_name", "no name");
        }   else {
            PlayerPrefs.SetString ("Player_name", "no name");
        }

        player_name_text.text = PlayerPrefs.GetString ("Player_name", "no name");
        player_name_inputfield.text = PlayerPrefs.GetString ("Player_name", "no name");

        if(PlayerPrefs.HasKey("comment")) {
            comment_inputfield.text = PlayerPrefs.GetString ("comment", "No comment");
        } else {
            PlayerPrefs.SetString ("comment", "No comment");
        }

        comment_text.text = PlayerPrefs.GetString ("comment", "No comment");
        comment_inputfield.text = PlayerPrefs.GetString ("comment", "No comment");

        if (PlayerPrefs.HasKey("morning") && PlayerPrefs.GetInt ("morning") == 1) {
            morning.isOn = true;
        } else {
            PlayerPrefs.SetInt("morning",0);
            morning.isOn = false;
        }
        morning_on.SetActive (morning.isOn);

        if (PlayerPrefs.HasKey("daytime") && PlayerPrefs.GetInt ("daytime") == 1) {
            daytime.isOn = true;
        } else {
            PlayerPrefs.SetInt("daytime",0);
            daytime.isOn = false;
        }
        daytime_on.SetActive (daytime.isOn);

        if (PlayerPrefs.HasKey("night") && PlayerPrefs.GetInt ("night") == 1) {
            night.isOn = true;
        } else {
            PlayerPrefs.SetInt("night",0);
            night.isOn = false;
        }
        night_on.SetActive (night.isOn);

    }

    public void Pressed_OK(){
        PlayerPrefs.SetString ("Player_name", player_name_inputfield.text);
        player_name_inputfield.text = PlayerPrefs.GetString ("Player_name", "unknown");
        player_name_text.text = PlayerPrefs.GetString ("Player_name", "unknown");

        PlayerPrefs.SetString ("Comment", comment_inputfield.text);
        comment_inputfield.text = PlayerPrefs.GetString ("Comment", "unknown");
        comment_text.text = PlayerPrefs.GetString ("Comment", "unknown");

        if (morning.isOn == true) {
            PlayerPrefs.SetInt ("morning", 1);
        } else {
            PlayerPrefs.SetInt ("morning", 0);
        }
        morning_on.SetActive (morning.isOn);

        if (daytime.isOn == true) {
            PlayerPrefs.SetInt ("daytime", 1);
        } else {
            PlayerPrefs.SetInt ("daytime", 0);
        }
        daytime_on.SetActive (daytime.isOn);

        if (night.isOn == true) {
            PlayerPrefs.SetInt ("night", 1);
        } else {
            PlayerPrefs.SetInt ("night", 0);
        }
        night_on.SetActive (night.isOn);

    }

}
