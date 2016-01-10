using UnityEngine;
using System.Collections;

public class ScrollController : MonoBehaviour {
    
    public RectTransform prefab = null;

    void Start () {
        for(int i = 0; i < 15; ++i) {
            var item = GameObject.Instantiate(prefab) as RectTransform;
            item.SetParent(transform, false);
        }
    }
}
