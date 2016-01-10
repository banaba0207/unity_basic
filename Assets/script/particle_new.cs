using UnityEngine;
using System.Collections;

public class particle_new : MonoBehaviour {
	public GameObject particle_anime;
	public Canvas canvas;


	void Update () {
		if (Input.GetMouseButtonUp (0)) {
			Debug.Log ("Mouse:" + Input.mousePosition);
//			particle_anime.transform.localPosition = Input.mousePosition;
//			particle_anime.transform.Translate( - canvas.transform.position.x, - canvas.transform.position.y, 0f);

//			particle_anime.GetComponent<RectTransform>().anchoredPosition = Input.mousePosition;
//			particle_anime.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			particle_anime.transform.position = Input.mousePosition;
			particle_anime.SetActive(true);

			Debug.Log (particle_anime.GetComponent<RectTransform>().anchoredPosition);
			particle_anime.GetComponent<Animator>().SetTrigger("In");
		}
	}

//	void Update() {
//		Vector3 _WorldPoint = _Camera.ScreenToWorldPoint(Input.mousePosition);
//		if (Input.GetMouseButtonUp(0)) {
//			_Obj.transform.position = _WorldPoint;
//		}
//	}

	public void close_obj(){
		particle_anime.SetActive (false);
	}
}
