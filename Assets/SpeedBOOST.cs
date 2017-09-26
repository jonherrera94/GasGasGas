using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SpeedBOOST : MonoBehaviour {
    public GameObject thisone;
    public FirstPersonController fpscom;
    public AudioSource nyoom;
    
	// Use this for initialization
	void Start () {
        fpscom = (FirstPersonController)GameObject.FindGameObjectWithTag("Player").GetComponent("FirstPersonController");
    }
	
	// Update is called once per frame
	void Update () {
        thisone.transform.Rotate(Vector3.forward * Time.deltaTime * 100);
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            nyoom.Play();
            if (fpscom.drivebar.Value > .9f)
            {
                fpscom.drivebar.Value = 1f;
                Destroy(thisone);
            }
            else
            {
                fpscom.drivebar.Value += 0.1f;
                Destroy(thisone);
            }
            
        }
    }
}
