using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_interaction : MonoBehaviour
{
    private bool trigger = false;
    private bool interactionIsTrigger = false;

    void Update()
    {
        if (trigger && Input.GetKeyDown(KeyCode.E))
        {
            //code for interaction
            if (!interactionIsTrigger)
            {
                interactionIsTrigger = true;
                //interaction
            }
            else
            {
                //interaction
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            trigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            trigger = false;
        }
    }
    
}
