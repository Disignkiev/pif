using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoaScene : MonoBehaviour {
    [SerializeField]
    public string snames="game";
    [SerializeField]
    public int vally;
    public int vally2;

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(this.gameObject);
    }
    public void Sceneitem1()
    {

        

      


    }
    public void clickload()
    {
        GameObject goo;
       goo= GameObject.FindGameObjectWithTag("load");
        vally = goo.GetComponent<Dropdown>().value;
        if (vally == 0)
        {

            snames = "game";
            Debug.Log(snames);
            vally2 = 4;
        }

        if (vally == 1)
        {

            snames = "game2";
            Debug.Log(snames);
            vally2 = 5;
        }

        if (vally == 2)
        {

            snames = "game3";
            Debug.Log(snames);
            vally2 = 7;
        }
        if (vally == 3)
        {

            snames = "game4";
            Debug.Log(snames);
            vally2 = 9;
        }

        if (vally == 4)
        {

            snames = "game5";
            Debug.Log(snames);
            vally2 = 17;
        }
        if (vally == 5)
        {

            snames = "game6";
            Debug.Log(snames);
            vally2 = 25;
        }
        clickinit(snames);
        Debug.Log(snames);
    }
    public   void clickinit(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    


    // Update is called once per frame
    void Update () {
   
    }
}
