using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour {


    public int stageNo = 1;

    public GameObject stage1;
    public GameObject stage2;
    public GameObject stage3;
    public GameObject Ending;

    public TextMesh timeText;

    AudioSource audioSource;

    // Use this for initialization
    void Start () {
        stage1.SetActive(true);
        stage2.SetActive(false);
        stage3.SetActive(false);
        Ending.SetActive(false);

        audioSource = this.gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        GameObject[] items = GameObject.FindGameObjectsWithTag("Item");

        //Debug.Log("Item rest = " + items.Length);

        if(items.Length == 0)
        {
            GoNextStage();
            Debug.Log("Stage Clear!");
        }
    }

    void GoNextStage()
    {
        stageNo++;

        if(stageNo == 2)
        {
            audioSource.Play();
            stage1.SetActive(false);
            stage2.SetActive(true);
            stage3.SetActive(false);
        }
        if (stageNo == 3)
        {

            stage1.SetActive(false);
            stage2.SetActive(false);
            stage3.SetActive(true);

            audioSource.Play();
        }
        if (stageNo == 4)
        {
            timeText.text = "Time : " + Time.timeSinceLevelLoad + " second";
            stage1.SetActive(false);
            stage2.SetActive(false);
            stage3.SetActive(true);

            audioSource.Play();
            Debug.Log("Stage All Clear!");

            Ending.SetActive(true);
        }
    }
}
