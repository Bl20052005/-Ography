using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class testingFade : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI currText;


    void Update()
    {
        FadeText(currText);
    }

    void FadeText(TextMeshProUGUI currText)
    {

        currText.CrossFadeAlpha(1.0f, 7.0f, false);
        /*
                if (currText.color.a < 1.0f)
                {
                    currText.color = new Color(currText.color.r, currText.color.g, currText.color.b, currText.color.a + .01f);
                    Debug.Log(currText.color.a);
                }
        */
    }
}
