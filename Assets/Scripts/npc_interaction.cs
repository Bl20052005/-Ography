using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_interaction : MonoBehaviour
{
    private bool trigger = false;
    void update()
    {
        if (trigger && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(this.gameObject);
        }
    }
    // on trigger dialogue
    void onTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            trigger = true;
        }
    }

    void onTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            trigger = false;
        }
    }
}
