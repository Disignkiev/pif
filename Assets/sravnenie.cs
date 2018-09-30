using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sravnenie : MonoBehaviour {
    string [] text2;

    public GameObject[] iooh;
    public GameObject[] iooh2;
    // Use this for initialization
    void Start()
    {
      
    }
 

    public void st()
    {
        iooh = GameObject.FindGameObjectsWithTag("calldes");

        for (int i = 0; i < iooh.Length; i++)
        {
            iooh[i].GetComponent<Text>().enabled = true;

           // text2[i] = iooh[i].GetComponent<Text>().text;
            //Transform child = transform.GetChild(2);

        }

        iooh2 = GameObject.FindGameObjectsWithTag("call");

        for (int i = 0; i < iooh2.Length; i++)
        {
            int t2 = iooh2[i].GetComponent<Drop>().t;

            if (t2 == 1) {
                iooh2[i].GetComponent<Image>().color = new Color32(255, 0, 255, 100);


            }


        }

        }


    // Update is called once per frame
    void Update () {
		
	}
}
