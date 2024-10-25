using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShouldKeyAppear : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject key;
    private HasKey has_key;

    void Start()
    {
        //gameObject.SetActive(false);
        has_key = player.GetComponent<HasKey>();
    }

    // Update is called once per frame
    void Update()
    {
        if(has_key.DoesHaveKey())
        {
            key.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
