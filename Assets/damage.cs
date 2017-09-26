using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class damage : MonoBehaviour {
    public AudioSource ouch;
    private FirstPersonController fpscom;
    // Use this for initialization
    void Start() {
        fpscom = (FirstPersonController)GameObject.FindGameObjectWithTag("Player").GetComponent("FirstPersonController");
    }

    // Update is called once per frame
    void Update() {

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            ouch.Play();
            fpscom.healthbar.Value -= .2f;

            if(fpscom.healthbar.Value <= .2f)
            {
                fpscom.respawn();

            }
 
             
        }
    }
}

