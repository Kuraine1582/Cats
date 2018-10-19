using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock3 : MonoBehaviour {

    [SerializeField]
    GameObject panel;

    bool Anlock3 = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Anlock3)
        {
            panel.SetActive(false);
        }

        //チートコード
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            panel.SetActive(false);
        }
    }
}
