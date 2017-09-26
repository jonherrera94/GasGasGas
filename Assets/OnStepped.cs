using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStepped : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public class StepOnPlatform : MonoBehaviour
    {


        void OnControllerColliderHit(ControllerColliderHit other) {
            if (other.gameObject.tag.Equals("platform"))
                other.gameObject.GetComponent<DestroyAtDistance>().SetPlayerStepped(true);
        }
    }
}
