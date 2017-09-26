using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class HealthPack : MonoBehaviour {
    public GameObject thisone;
    public FirstPersonController fpscom;
    public AudioSource yum;

    // Use this for initialization
    void Start()
    {
        fpscom = (FirstPersonController)GameObject.FindGameObjectWithTag("Player").GetComponent("FirstPersonController");
    }

    // Update is called once per frame
    void Update()
    {
        thisone.transform.Rotate(Vector3.up * Time.deltaTime * 100);
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            yum.Play();
            if (fpscom.healthbar.Value < .9f)
            {
                fpscom.healthbar.Value += .2f;
                Destroy(thisone);
            }
            
           
        }
    }
}
