using UnityEngine;
using System.Collections;

public class ReturnMenuDisp: MonoBehaviour {
    public GameObject option;
    public GameObject friend;
    public GameObject player_info;
    public GameObject items;
    public GameObject data_hikitugi;
    public GameObject menu;
    public GameObject slideout_obj;
    public GameObject black_bord;
    public GameObject fotter_barrier_bord;

    public FotterTextMove fotter_text;
    float waittime = 0.4f;


    public void OnclickedReturnMenu(){
        slideout_obj.GetComponent<Animator> ().SetTrigger ("return_Out");
        OnClickedFotterMenu();
    }

    public void OnClickedFotterMenu(){ 
        fotter_barrier_bord.SetActive (true);
        black_bord.SetActive (true);
        black_bord.GetComponent<Animator> ().SetTrigger ("In");
        StartCoroutine (ReopenMenu ());
    }

    IEnumerator ReopenMenu(){
        fotter_text.SetFastMoveEndX (172);
        fotter_text.SetScrollEndX (-486);
        fotter_text.SetFotterText ("解らない事があったら、ヘルプをタッチしてください。  色々な機能を使って、ゲームをより楽しんでください。");
        fotter_text.init_txt ();

        yield return new WaitForSeconds (waittime); 
        black_bord.GetComponent<Animator> ().SetTrigger ("Out");
        
        friend.SetActive (false);
        player_info.SetActive (false);
        items.SetActive (false);
        option.SetActive (false);
        data_hikitugi.SetActive (false);
        menu.SetActive (false);
        menu.SetActive (true);
        
        fotter_barrier_bord.SetActive (false);
    }
}
