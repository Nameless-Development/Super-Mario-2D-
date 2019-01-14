using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPerspectiveScript : MonoBehaviour
{

	public Camera cam;

	int lastchanged = -60;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
		{
			if (Time.frameCount - lastchanged <= 60) return;
			var ort = cam.orthographic;
			cam.orthographic = !ort;
			lastchanged = Time.frameCount;
		}
	}
}
