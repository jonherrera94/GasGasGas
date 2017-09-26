using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorGenerator : MonoBehaviour {
    public GameObject floorpanel;
    public float distance = 100;
    Vector3 starting = Vector3.zero;
    public SpeedBOOST boop;
    public GameObject spball;
    public GameObject ringfire;
    public GameObject healthpack;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Camera.main.transform.position, starting) < distance)
        {
            Instantiate(floorpanel, starting, transform.rotation);
            starting += new Vector3(Random.Range(-5,7), Random.Range(-2,3), 20f);
            int boostchance = Random.Range(1, 100);
            if (boostchance >= 80)
            {
                Instantiate(boop, new Vector3(starting.x+Random.Range(1, 3), starting.y+Random.Range(1,3),starting.z+Random.Range(1, 3)), new Quaternion(0,0,-30,-15));
            }
            boostchance = Random.Range(1, 100);
            if (boostchance >= 80)
            {
                Instantiate(spball, new Vector3(starting.x + Random.Range(-2, 6), starting.y + Random.Range(1, 3), starting.z + Random.Range(-4, 2)), new Quaternion(0, 0, -30, -15));
            }
            boostchance = Random.Range(1, 100);
            if (boostchance >= 90)
            {
                Instantiate(ringfire, new Vector3(starting.x + Random.Range(-2, 6), starting.y+3, starting.z + Random.Range(-4, 2)), new Quaternion(0, 0, -30, -15));
            }
            if (boostchance >= 80)
            {
                Instantiate(healthpack, new Vector3(starting.x + Random.Range(-2, 2), starting.y+2, starting.z + Random.Range(-4, 1)), new Quaternion(0, 0, -30, -15));
            }
        }
    }
} 
	

