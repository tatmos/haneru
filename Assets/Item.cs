﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {


    // Use this for initialization
    void Start()
    {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ItemAtari!");
        GameObject.Destroy(this.gameObject);
    }
}
