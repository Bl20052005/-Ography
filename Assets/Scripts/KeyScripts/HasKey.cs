using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasKey : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int key;

    void Start()
    {
        key = 0;
    }

    public void SetKey(int set)
    {
        key = set;
        Debug.Log(key);
    }

    public bool DoesHaveKey()
    {
        Debug.Log("wttttt key");
        Debug.Log(key);
        return key == 1;
    }
}
