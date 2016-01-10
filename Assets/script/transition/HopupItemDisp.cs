using UnityEngine;
using System.Collections;

public class HopupItemDisp : MonoBehaviour {

    public RectTransform prefab = null;

    public void Onclicked(){
        var item = GameObject.Instantiate(prefab) as RectTransform;
//        item.SetParent(transform, false);

    }
}
