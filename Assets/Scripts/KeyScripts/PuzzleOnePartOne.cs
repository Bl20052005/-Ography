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
        if(collision.gameObject.tag == "Player")
        {
            HasKey has_key = collision.gameObject.GetComponent<HasKey>();
            has_key.SetKey(1);
        }

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
