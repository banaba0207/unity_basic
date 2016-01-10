using UnityEngine;
using System.Collections;

public class OpenAndCloseHopupDisp : MonoBehaviour {

    public GameObject open_obj;
    public GameObject close_obj;

    public GameObject barrier_bord;

    public void OnclickedOpenHopupDisp(){
        open_obj.SetActive (true);
        open_obj.GetComponent<Animator> ().SetTrigger ("In");
        barrier_bord.SetActive (true);
    }

    public void OnclickedClosedHopupDisp(){
        close_obj.GetComponent<Animator> ().SetTrigger ("Out");
        barrier_bord.SetActive (false);
        StartCoroutine( CloseObj() );
    }

    IEnumerator CloseObj() {
        yield return new WaitForSeconds (0.3f);
        close_obj.SetActive(false);
    }


}
