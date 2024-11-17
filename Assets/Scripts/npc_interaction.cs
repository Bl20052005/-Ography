using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_interaction : MonoBehaviour
{
    public Dialogue dialogue;
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
                TriggerDialogue();
            }
            else
            {
                ExecuteDialogue();
            }
        }
    }

    public void TriggerDialogue(){
        FindObjectOfType<DialogueHandler>().StartDialogue(dialogue);
    }

    public void ExecuteDialogue(){
        FindObjectOfType<DialogueHandler>().DisplayNextSentence();
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
