using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drop : MonoBehaviour,IDropHandler {
    [SerializeField]
    public int t = 0;
    public void OnDrop(PointerEventData eventData)
 
    {
      string text12;
      string text13;
      drag f = eventData.pointerDrag.GetComponent<drag>();
        f.gh.transform.SetParent(this.gameObject.transform);
        text12 = GetComponentInChildren<Text>().text;
        text13 = f.GetComponent<Text>().text;
        if (text12 == text13)
        {
            Debug.Log(text12);
          //  gameObject.GetComponent<Image>().color = new Color32(255, 0, 255,100);
            t = 1;
        }


    }

    // Use this for initialization
    void Start () {


    }

    // Update is called once per frame
    void Update () {
		
	}
}
