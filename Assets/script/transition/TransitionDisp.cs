using UnityEngine;
using System.Collections;

public class TransitionDisp : MonoBehaviour {

    public GameObject menu;
    public GameObject dest_disp; //遷移先
    public GameObject return_bord;
    public GameObject main_disp;

    public GameObject black_bord;
    public GameObject fotter_barrier_bord;

    public FotterTextMove fotter_text;

    float waittime = 0.4f;

    public void OnClicked(string setting_text){
        StartCoroutine (TransDisp ());
        fotter_barrier_bord.SetActive (true);
        black_bord.SetActive (true);
        black_bord.GetComponent<Animator> ().SetTrigger ("In");

        fotter_text.SetFastMoveEndX (171);
        fotter_text.SetScrollEndX (-585);
        fotter_text.SetFotterText (setting_text);
        fotter_text.init_txt ();
    }

    IEnumerator TransDisp(){
        yield return new WaitForSeconds (waittime); 
        menu.SetActive (false);
        dest_disp.SetActive (true);

        black_bord.GetComponent<Animator> ().SetTrigger ("Out");
        return_bord.GetComponent<Animator> ().SetTrigger ("SlideIn");
        main_disp.GetComponent<Animator> ().SetTrigger ("In");
        fotter_barrier_bord.SetActive (false);
    }

}
