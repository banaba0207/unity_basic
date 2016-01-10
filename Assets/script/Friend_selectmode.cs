using UnityEngine;
using System.Collections;

public class Friend_selectmode : MonoBehaviour {

    public GameObject list_on;
    public GameObject list_off;
    public GameObject list_scrollObj;
    public GameObject syounin_on;
    public GameObject syounin_off;
    public GameObject syounin_scrollObj;
    public GameObject search_on;
    public GameObject search_off;
    public GameObject search_obj;
    public GameObject select_waku;

    public void WakuMove(int number){
        if(number == 1) SelectList();
        if(number == 2) SelectSyounin();
        if(number == 3) SelectSearch();
    }
    
    public void SelectList() {
        list_on.SetActive(true);
        list_off.SetActive(false);
        syounin_on.SetActive(false);
        syounin_off.SetActive(true);
        search_on.SetActive(false);
        search_off.SetActive(true);
        iTween.MoveTo(select_waku, iTween.Hash(
                    "x", -332.3,
                    "islocal", true
                    ));

        list_scrollObj.SetActive(true);
        syounin_scrollObj.SetActive(false);
        search_obj.SetActive(false);
    }
    
    public void SelectSyounin() {
        list_on.SetActive(false);
        list_off.SetActive(true);
        syounin_on.SetActive(true);
        syounin_off.SetActive(false);
        search_on.SetActive(false);
        search_off.SetActive(true);
        iTween.MoveTo(select_waku, iTween.Hash(
                    "x", 5,
                    "islocal", true
                    ));
        list_scrollObj.SetActive(false);
        syounin_scrollObj.SetActive(true);
        search_obj.SetActive(false);
    }

    public void SelectSearch() {
        list_on.SetActive(false);
        list_off.SetActive(true);
        syounin_on.SetActive(false);
        syounin_off.SetActive(true);
        search_on.SetActive(true);
        search_off.SetActive(false);
        iTween.MoveTo(select_waku, iTween.Hash(
                    "x", 335.22,
                    "islocal", true
                    ));
        list_scrollObj.SetActive(false);
        syounin_scrollObj.SetActive(false);
        search_obj.SetActive(true);
    }
}
