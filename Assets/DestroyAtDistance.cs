using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAtDistance : MonoBehaviour { 
    public float distance = 100;
    public bool playerStepped = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(Camera.main.transform.position, transform.position) > distance && playerStepped == true)
        { Destroy(gameObject); }
    }
    public void SetPlayerStepped(bool step) { playerStepped = step; }
}

