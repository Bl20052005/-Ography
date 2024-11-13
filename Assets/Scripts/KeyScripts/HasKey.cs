using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasKey : MonoBehaviour
{

    /* TLDR

    if Player collides with a 'Key' object, turn hasKey to true

    also contains a public SetKey(bool) and GetKey() method to get key status

    */

    // hasKey is static so that it will be persist across scenes
    static bool hasKey = false;
    //copyHasKey is used for debugging purposes so that I can see the state of hasKey in the editor 
    // bc static variables dont show up on the editor
    [SerializeField] private bool copyHasKey = hasKey;

    void Start()
    {
        copyHasKey = hasKey;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.gameObject.tag);

        if (other.gameObject.tag == "Key")
        {
            other.gameObject.SetActive(false);
            SetKey(true);
            copyHasKey = hasKey;
        }
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
    }
}
