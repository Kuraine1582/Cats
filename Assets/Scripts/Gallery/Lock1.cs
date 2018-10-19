using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock1 : MonoBehaviour {

    [SerializeField]
    GameObject panel;

    bool Anlock1 = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Anlock1)
        {
            panel.SetActive(false);
        }

        //チートコード
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            panel.SetActive(false);
        }
    }
}
