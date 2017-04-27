using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAtari : MonoBehaviour {

    public AudioClip cubeAtari;
    public AudioClip itemGet;
    public AudioClip itemGet2;
    public AudioClip itemGet3;

    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = this.gameObject.GetComponent<AudioSource>();

    }

    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Item")
        {
            audioSource.clip = itemGet;
        }
        if (collision.gameObject.name == "Item2")
        {
            audioSource.clip = itemGet2;
        }
        if (collision.gameObject.name == "Item3")
        {
            audioSource.clip = itemGet3;
        }

        audioSource.Play();
        Debug.Log("Atari!" + collision.gameObject.name);
    }
}
