using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasKeyorFlag : MonoBehaviour
{

    /* TLDR

    if Player collides with a 'Key' object, turn hasKey to true

    also contains a public SetKey(bool) and GetKey() method to get key status

    */

    // hasKey is static so that it will be persist across scenes
    static bool hasKey;
    static bool hasFlag;

    //copyHasKey is used for debugging purposes so that I can see the state of hasKey in the editor 
    // bc static variables dont show up on the editor
    [SerializeField] private bool copyHasKey = hasKey;
    [SerializeField] private bool copyHasFlag = hasFlag;

    void Awake()
    {
        hasKey = PlayerPrefs.GetInt("hasKey", 0) == 1;
        hasFlag = PlayerPrefs.GetInt("hasFlag", 0) == 1;
    }
    void Start()
    {
        copyHasKey = hasKey;
        copyHasFlag = hasFlag;

    }

    void Update()
    {

        // debug only
        hasFlag = copyHasFlag;
        ////

        PlayerPrefs.SetInt("hasKey", hasKey ? 1 : 0);
        PlayerPrefs.SetInt("hasFlag", hasFlag ? 1 : 0);
        PlayerPrefs.Save();


    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.gameObject.tag);

        if (other.gameObject.tag == "Key")
        {
            other.gameObject.SetActive(false);
            SetKey(true);

        }
        if (other.gameObject.tag == "flagNpc")
        {

            SetFlag(true);
            copyHasFlag = hasFlag;
        }

    }

    public void SetFlag(bool state)
    {
        hasFlag = state;
        Debug.Log("flag is set to " + state);
    }
    public bool GetFlag()
    {
        return hasFlag;
    }

    public void SetKey(bool state)
    {
        hasKey = state;
        copyHasKey = hasKey;
        Debug.Log(hasKey);
    }


    public bool DoesHaveKey()
    {
        Debug.Log("wttttt key");
        Debug.Log(hasKey);
        return hasKey;
    }
    public void ResetAllVals()
    {
        hasKey = false;
        copyHasKey = false;
        hasFlag = false;

    }
}
