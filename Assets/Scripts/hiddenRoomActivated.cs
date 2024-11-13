using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenRoomActivated : MonoBehaviour
{
/*
tldr

Allows access to keyRoom once flag is true

*/
    [SerializeField] FlagKeyLogic flagKeyLogic;
    BoxCollider2D boxCollider2D;

    // Start is called before the first frame update

    void Awake()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
    // Update is called once per frame
    void Update()
    {
        activateIfFlag();
    }

    void activateIfFlag()
    {
        if (flagKeyLogic.hasFlag())
        {
            boxCollider2D.enabled = true;
        }
    }

}
