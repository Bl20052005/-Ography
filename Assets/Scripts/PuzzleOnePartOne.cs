using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleOnePartOne : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hello!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Do something
        Debug.Log("hello there!");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
