using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour {

    // Use this for initialization
    public Light lt;
	void Start () {
        lt = GetComponent<Light>();
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (lt.color == Color.white)
                lt.color = Color.red;
            else if (lt.color == Color.red)
                lt.color = Color.blue;
            else
                lt.color = Color.white;
        }
	}
}
