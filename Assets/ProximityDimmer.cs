using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityDimmer : MonoBehaviour {
    // Use this for initialization
    public Light lt;
    void Start () {
        lt = GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = GameObject.Find("Player").transform.position;
        float X = pos.x;
        float Z = pos.z;
        float distance = Mathf.Sqrt(X * X + Z * Z);
        lt.intensity = Mathf.Sqrt(5*5 + 5*5) - distance;    //This is the distance from the center to a corner
	}
}
