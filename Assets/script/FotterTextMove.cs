using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FotterTextMove : MonoBehaviour {
	string fotter_txt;
	float to_scroll_x;
	float fastmove_x;
	Vector3 startPosition = new Vector3(609f, 43.2f, 0);

	public void SetFastMoveEndX(float set_x){
		fastmove_x = set_x;
	}

	public void SetScrollEndX(float set_x){
		to_scroll_x = set_x;
	}

	public void SetFotterText(string set_txt){
		fotter_txt = set_txt;
	}

	// Use this for initialization
	void Start () {
		fotter_txt = "解らない事があったら、ヘルプをタッチしてください。  色々な機能を使って、ゲームをより楽しんでください。";
		to_scroll_x = -585;
		fastmove_x = 172;
		//startPosition = this.gameObject.transform.localPosition;
		this.GetComponent<Text>().text = fotter_txt;
		FastMove_txt ();
	}

	public void init_txt(){
		iTween.Stop ();
		this.GetComponent<Text>().text = fotter_txt;
		PositionInit_txt ();
		Scroll_txt ();
	}

	void PositionInit_txt(){
		this.gameObject.transform.localPosition = new Vector3(fastmove_x, 43.2f, 0);
	}

	void PositionInit2_txt(){
		this.gameObject.transform.localPosition = startPosition;
		FastMove_txt ();
	}

	void FastMove_txt(){
		iTween.MoveTo(this.gameObject, iTween.Hash(
			"x", fastmove_x,
			"delay", 3,
			"speed", 1000,
			"islocal", true,
			"easeType",iTween.EaseType.linear,
			"oncomplete", "Scroll_txt"
			));
	}
	void Scroll_txt(){
		iTween.MoveTo(this.gameObject, iTween.Hash(
			"x", to_scroll_x,
			"delay", 3,
			"speed", 100,
			"islocal", true,
			"easeType",iTween.EaseType.linear,
			"oncomplete", "PositionInit2_txt"
			));
	}


	

}
