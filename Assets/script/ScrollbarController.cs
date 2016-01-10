using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScrollbarController : MonoBehaviour {

    bool scrollBarEnable = false;
    public GameObject scrollBarBase;
    public GameObject scrollBar;

    public void EnableScrollBar() {
        if(scrollBarEnable == false) {
            scrollBarEnable = true;
            scrollBar.SetActive(true);
            scrollBarBase.SetActive(true);
            Invoke("DisableScrollBar", 1);
            Invoke("ActiveFalse", 3);
        }
    }
    
    void DisableScrollBar() {
        iTween.ValueTo(scrollBarBase, iTween.Hash(
                    "from", 1.0f,
                    "to", 0f,
                    "time", 2f,
                    "onupdate", "SetValue"
                    ));
        scrollBarEnable = false;
    }

    void SetValue(float alpha) {
        scrollBarBase.GetComponent<UnityEngine.UI.Image>().color = new Color(255, 255, 255, alpha);
        scrollBar.GetComponent<UnityEngine.UI.Image>().color = new Color(255, 255, 255, alpha);
    }

    void ActiveFalse() {
        scrollBarBase.SetActive(false);
        scrollBar.SetActive(false);
        scrollBarEnable = false;
    }
}
