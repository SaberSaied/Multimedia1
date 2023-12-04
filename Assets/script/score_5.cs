using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score5 : MonoBehaviour
{
    public GameObject pnal1;
    public GameObject pnal2;
    public GameObject pnal3;
    public GameObject pnal4;
    public GameObject pnal5;
    public GameObject pnal6;
    public GameObject pnal7;
    public GameObject pnal8;
    public GameObject pnal9;
    public GameObject pnal10;
    public GameObject pnal11;
    public GameObject pnal12;
    Text Text;
    public static int scor5 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = scor5.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scor5 == 5) Destroy(pnal1);
        else if (scor5 == 10) Destroy(pnal2);
        else if (scor5== 15) Destroy(pnal3);
        else if (scor5 == 20) Destroy(pnal4);
        else if (scor5 == 25) Destroy(pnal5);
        else if (scor5== 30) Destroy(pnal6);
        else if (scor5== 35) Destroy(pnal7);
        else if (scor5 == 40) Destroy(pnal8);
        else if (scor5 == 45) Destroy(pnal9);
        else if (scor5 == 50) Destroy(pnal10);
        else if (scor5 == 55) Destroy(pnal11);
        else if (scor5== 60) Destroy(pnal12);

        scor5 = 0;
    }
}


