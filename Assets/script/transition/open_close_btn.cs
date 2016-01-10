using UnityEngine;
using System.Collections;

public class open_close_btn : MonoBehaviour {
    public GameObject open_obj;
    public GameObject close_obj;
    public GameObject option;
    public GameObject player_info;
    public GameObject friend;
    public GameObject items;
    public GameObject data_hikitugi;
    public GameObject menu;

    public GameObject return_bord;
    public GameObject middle_disp;

    public GameObject black_bord;
    public GameObject black_bord_onFotter;
    public GameObject fotter_barrier_bord;

    public FotterTextMove fotter_text;

    public float waittime = 0.4f;

    public void Onclicked_open(){
        open_obj.SetActive (true);
        open_obj.GetComponent<Animator> ().SetTrigger ("In");
        black_bord_onFotter.SetActive (true);
    }

    public void Onclicked_close(){
        close_obj.GetComponent<Animator> ().SetTrigger ("Out");
        black_bord_onFotter.SetActive (false);
    }

    public void obj_close(){
        close_obj.SetActive (false);
    }

    public void OnClickedFotterMenu(){ //{{{
        StartCoroutine (open_menu ());
        fotter_barrier_bord.SetActive (true);
        black_bord.SetActive (true);
        black_bord.GetComponent<Animator> ().SetTrigger ("In");

        fotter_text.SetFastMoveEndX (172);
        fotter_text.SetScrollEndX (-486);
        fotter_text.SetFotterText ("解らない事があったら、ヘルプをタッチしてください。  色々な機能を使って、ゲームをより楽しんでください。");
        fotter_text.init_txt ();
    }

    IEnumerator open_menu(){
        yield return new WaitForSeconds (waittime); 
        option.SetActive (false);
        player_info.SetActive (false);
        friend.SetActive(false);
        items.SetActive(false);
        data_hikitugi.SetActive(false);
        menu.SetActive (false);
        menu.SetActive (true);

        yield return new WaitForSeconds (waittime); 
        fotter_barrier_bord.SetActive (false);

        black_bord.GetComponent<Animator> ().SetTrigger ("Out");
    }
    //}}}

    public void OnClickedFriend(){ //{{{
        StartCoroutine (open_friend ());
        black_bord.SetActive (true);
        black_bord.GetComponent<Animator> ().SetTrigger ("In");

        fotter_text.SetFastMoveEndX (171);
        fotter_text.SetScrollEndX (-585);
        fotter_text.SetFotterText ("あなたのフレンドリストです。　フレンド解除ボタンを押すと、フレンドを解除することが出来ます。");
        fotter_text.init_txt ();
    }

    IEnumerator open_friend(){
        yield return new WaitForSeconds (waittime); 
        menu.SetActive (false);
        friend.SetActive (true);

        black_bord.GetComponent<Animator> ().SetTrigger ("Out");
        return_bord.GetComponent<Animator> ().SetTrigger ("SlideIn");
        middle_disp.GetComponent<Animator> ().SetTrigger ("In");
    }
    //}}}

    public void OnClickedPlayerInfo(){ //{{{
        StartCoroutine (open_player_info ());
        black_bord.SetActive (true);
        black_bord.GetComponent<Animator> ().SetTrigger ("In");

        fotter_text.SetFastMoveEndX (171);
        fotter_text.SetScrollEndX (-585);
        fotter_text.SetFotterText ("プレイヤー情報の確認と設定ができます。フレンドにアピールするコメントを設定しましょう。");
        fotter_text.init_txt ();
    }

    IEnumerator open_player_info(){
        yield return new WaitForSeconds (waittime); 
        menu.SetActive (false);
        player_info.SetActive (true);

        black_bord.GetComponent<Animator> ().SetTrigger ("Out");
        return_bord.GetComponent<Animator> ().SetTrigger ("SlideIn");
        middle_disp.GetComponent<Animator> ().SetTrigger ("In");
    }
    //}}}

    public void BlackBordClose(){
        black_bord.SetActive (false);
    }

    public void OnClickedOptionSetting(){ //{{{
        StartCoroutine (open_option_setting ());
        black_bord.SetActive (true);
        black_bord.GetComponent<Animator> ().SetTrigger ("In");

        fotter_text.SetFastMoveEndX (171);
        fotter_text.SetScrollEndX (-592);
        fotter_text.SetFotterText ("音の設定やプッシュ通知の設定ができます。　プレイスタイルに応じて、遊びやすい設定に調整をしてください。");
        fotter_text.init_txt ();
    }

    IEnumerator open_option_setting(){
        yield return new WaitForSeconds (waittime); 
        menu.SetActive (false);
        player_info.SetActive (false);
        option.SetActive (true);

        black_bord.GetComponent<Animator> ().SetTrigger ("Out");
        return_bord.GetComponent<Animator> ().SetTrigger ("SlideIn");
        middle_disp.GetComponent<Animator> ().SetTrigger ("In");
    }
    //}}}
    
    public void OnClickedItems(){ //{{{
        StartCoroutine (open_items());
        black_bord.SetActive (true);
        black_bord.GetComponent<Animator> ().SetTrigger ("In");

        fotter_text.SetFastMoveEndX (171);
        fotter_text.SetScrollEndX (-592);
        fotter_text.SetFotterText ("所持しているアイテムの確認が出来ます。　アイテムはセールがお得！　セールが行われていないか、ときどきショップをチェックしましょう。");
        fotter_text.init_txt ();
    }

    IEnumerator open_items(){
        yield return new WaitForSeconds (waittime); 
        menu.SetActive (false);
        items.SetActive (true);

        black_bord.GetComponent<Animator> ().SetTrigger ("Out");
        return_bord.GetComponent<Animator> ().SetTrigger ("SlideIn");
        middle_disp.GetComponent<Animator> ().SetTrigger ("In");
    }
    //}}}

    public void OnClickedDatahikitugi(){ //{{{
        StartCoroutine (open_datahikitugi());
        black_bord.SetActive (true);
        black_bord.GetComponent<Animator> ().SetTrigger ("In");

        fotter_text.SetFastMoveEndX (171);
        fotter_text.SetScrollEndX (-592);
        fotter_text.SetFotterText ("この端末から他の端末にデータを引き継ぎために必要な、パスワードの設定を行います。");
        fotter_text.init_txt ();
    }

    IEnumerator open_datahikitugi(){
        yield return new WaitForSeconds (waittime); 
        menu.SetActive (false);
        data_hikitugi.SetActive (true);

        black_bord.GetComponent<Animator> ().SetTrigger ("Out");
        return_bord.GetComponent<Animator> ().SetTrigger ("SlideIn");
        middle_disp.GetComponent<Animator> ().SetTrigger ("In");
    }
    //}}}

    IEnumerator Wait_close(){
        yield return new WaitForSeconds (waittime);
        //yield return null;
    }

}
