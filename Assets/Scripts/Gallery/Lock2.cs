using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock2 : MonoBehaviour {

    [SerializeField]
    GameObject panel;

    bool Anlock2 = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Anlock2)
        {
            panel.SetActive(false);
        }

        //チートコード
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            panel.SetActive(false);
        }
    }
}
