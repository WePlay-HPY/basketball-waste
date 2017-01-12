using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageBehavior : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GameObject basket = GameObject.FindGameObjectWithTag("Player");
        basket.GetComponent<Renderer>().material.mainTexture = Resources.Load("pic.jpg") as Texture2D;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
