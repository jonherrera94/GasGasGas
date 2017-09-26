using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Text text;
    public Text level;
    public float timesofar;
    public int leveli = 1;
    public float timeleft = 30f;
    public float t = 0;
    // Use this for initialization
    void Start () {
        timesofar = Time.time;
        
	}
	
	// Update is called once per frame
	void Update () {
        t = Time.time - timesofar;
        timeleft -= Time.deltaTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        text.text = minutes + ":" + seconds;
        if (timeleft < 0)
        {
            leveli++;
            level.text = "Level: " + leveli;
            timeleft = 30f;
        }
	}
}
