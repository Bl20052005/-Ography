using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    HasKeyorFlag hasKey;

    void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
        hasKey = FindObjectOfType<HasKeyorFlag>();
    }
    // Update is called once per frame
    void Update()
    {

        if (hasKey != null)
            activateIfFlag();
    }

    void activateIfFlag()
    {
        if (hasKey.GetFlag())
        {
            boxCollider2D.enabled = true;
        }
    }

}
