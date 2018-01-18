using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour {

    // Use this for initialization
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Object entered trigger");
        GameObject sphere = GameObject.Find("Sphere 3");
        Rigidbody sphere3 = sphere.GetComponent<Rigidbody>();
        if (sphere3.useGravity == false)
        {
            sphere3.useGravity = true;
        }
    }
}
