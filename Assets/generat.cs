using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public class generat : MonoBehaviour {
    public GameObject[] des;
    public GameObject timerobj;
    public int timekoef;
    public float ik;
    [SerializeField]

   public GameObject ee;
    [SerializeField]
    public GameObject timegame;
    public bool ils = true;
   

    // Use this for initialization

    private IEnumerator Foo6()
    {
        yield return new WaitForSeconds(1);
       
    }

    void Awake() {

        ils = true;
    }
  public  void Start() {

        

        StartCoroutine(StartCountdown());

        des = GameObject.FindGameObjectsWithTag("calldes");
        timegame = GameObject.FindGameObjectWithTag("Time");
       
    }
    [SerializeField]
    public int citem = 9;
    public GameObject[] ui;
    public void Onclick()
        
    {
        Debug.Log("hello");
        

      Debug.Log("hello");
        if (ils==true)
        {
            ee = GameObject.FindGameObjectWithTag("loaddont");
            citem = ee.GetComponent<LoaScene>().vally2;
            ui = new GameObject[citem];
            string[] a = new string[citem];
            string[] mix = new string[citem];
            int[] pr = new int[citem];
            int h;
            int j = 0;
            string myText;
            GameObject gam;
            gam = GameObject.FindGameObjectWithTag("first");
            GameObject[] call;
            call = GameObject.FindGameObjectsWithTag("call");
            GameObject[] call2;
            call2 = GameObject.FindGameObjectsWithTag("call2");
            GameObject newobj;
            GameObject newobj2;



            for (int i = 0; i < citem; i++)
            {

                gam = Resources.Load("Text") as GameObject;


                newobj = Instantiate<GameObject>(gam);

                newobj.transform.SetParent(call[i].transform);

                newobj.transform.position = call[i].transform.position;
                newobj.tag = "calldes";
                myText = (Random.Range(0, 99)).ToString();
                newobj.GetComponent<Text>().text = myText;
                newobj.GetComponent<Text>().color = new Color32((byte)Random.Range(50, 200), (byte)Random.Range(50, 200), (byte)Random.Range(50, 200), (byte)255);
                a[j] = myText;
                ui[j] = newobj;

                h = Random.Range(0, citem);
                j++;




            }

            // Shuffle(a);
            Shuffle2(ui);

            for (int i = 0; i < citem; i++)
            {

                gam = Resources.Load("Text") as GameObject;


                newobj2 = Instantiate<GameObject>(gam);

                newobj2.transform.SetParent(call2[i].transform);

                newobj2.transform.position = call2[i].transform.position;
                //newobj2.GetComponent<Text>().text = a[i];
                newobj2.GetComponent<Text>().text = ui[i].GetComponent<Text>().text;
                newobj2.GetComponent<Text>().color = ui[i].GetComponent<Text>().color;
            }

            ils = false;
        }

    }
    void Shuffle(string[] block)
    {
        for (int i = 0; i < block.Length; i++)
        {
            string temp = block[i];
            int r = Random.Range(0, block.Length);
            block[i] = block[r];
            block[r] = temp;
        }
    }
    void Shuffle2(GameObject[] block)
    {
        for (int i = 0; i < block.Length; i++)
        {
            GameObject temp = block[i];
            int r = Random.Range(0, block.Length);
            block[i] = block[r];
            block[r] = temp;
        }
    }
    //  public float targetTime = 5.0f;
    //  void timer()
    //  {
    //     targetTime -= Time.deltaTime * ik;
    //
    //     if (targetTime <= 0.0f)
    //    {
    //       timerEnded();
    //     }
    // }

    //void timerEnded()
    //  {




    //   }

    void foll() {

        
        for (int i = 0; i <des.Length; i++)
        {
            if (des[i] != null)
                des[i].GetComponent<Text>().enabled = false;
            //des[i].SetActive(false);
            else
                break;
        }
    }
 //public  void foll3()
 // {

   
  //for (int i = 1; i < 24; i++)
   // {

  //          des[i].GetComponent<Text>().enabled = true; 
 //       }
//  }

    public void foll2(float newik)
    {
        ik = newik;
       // Debug.Log(ik);
    }
    // Update is called once per frame
    void Update () {
        
        //   timer();

    }

    float currCountdownValue;
    public IEnumerator StartCountdown()
    {
        currCountdownValue = ik;


        while (currCountdownValue > 0)
        {
            // Debug.Log("Countdown: " + currCountdownValue);
                      
            yield return new WaitForSeconds(1);
             timegame.GetComponent<Text>().text = currCountdownValue.ToString();
            currCountdownValue--;
        }

        timegame.GetComponent<Text>().text = "Move the numbers to the places you remember";
        foll();
    }

}
