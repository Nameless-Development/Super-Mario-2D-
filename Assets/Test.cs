using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    Transform t;
    Camera c;
    float scroll_loc;

	// Use this for initialization
	void Start () {
        t = this.transform;
        c = (Camera)this.GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("a"))
        {
            scroll_loc = t.position.x;
            if (c.orthographic)
            {
                t.position = new Vector3();
                c.orthographic = false;
            }
            else
            {
                t.position = new Vector3();
                t.rotation = new 
                c.orthographic = true;
            }
                
        }
	}
}
