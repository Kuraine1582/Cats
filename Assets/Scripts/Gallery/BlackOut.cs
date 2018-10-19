using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;     //UIを使用可能にする

public class BlackOut : MonoBehaviour {

    int TestCount = 0;

    float speed = 0.009f;  //透明化の速さ
    float alfa=1.0f;    //A値を操作するための変数
    float red, green, blue;    //RGBを操作するための変数
    Image image;
    bool Fadein = true;
    bool Fadeout = false;

    [SerializeField]
    GameObject panel;

    void Start()
    {
        image = GetComponent<Image>();       //Panelの色を取得
        red = image.color.r;
        green = image.color.g;
        blue = image.color.b;
    }

    public void StratFadeout()
    {
        Fadein = false;
        panel.SetActive(true);
        Fadeout = true;
    }

    void Update () {
        image.color = new Color(red, green, blue, alfa);
        if (Fadein)
        {
            alfa -= speed;
            TestCount++;
            if (alfa < 0)
            {
                alfa = 0;
                panel.SetActive(false);
                Fadein = false;
                Debug.Log(TestCount);
                Debug.Log("FadeinFinish");
            }
        }

        if (Fadeout)
        {
            image.color = new Color(red, green, blue, alfa);
            alfa += speed;
            if (alfa > 1)
            {
                Debug.Log("FadeoutFinish");
            }
        }
    }
}
