using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock4 : MonoBehaviour {

    [SerializeField]
    GameObject panel;

    bool Anlock4 = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Anlock4)
        {
            panel.SetActive(false);
        }

        //チートコード
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            panel.SetActive(false);
        }
    }
}
