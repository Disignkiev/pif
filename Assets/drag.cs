using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class drag : MonoBehaviour,IDragHandler,IEndDragHandler {
    public GameObject gh;

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
       
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = Vector3.zero;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    // Use this for initialization
    void Start () {
        gh = this.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
