using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAtari : MonoBehaviour {

    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = this.gameObject.GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
        Debug.Log("Atari!");
    }
}
