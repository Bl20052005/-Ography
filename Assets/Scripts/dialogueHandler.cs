using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueHandler : MonoBehaviour
{
    [SerializeField] private Text t;
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private GameObject dialogueArrow;

    void Start(){
        dialogueArrow.SetActive(false);
        showDialogueBox();
        displayMessage("hello hello hello\nhihihiihihihi\n");
    }

    public void showDialogueBox(){
        dialogueBox.SetActive(true);
    }

    public void removeDialogueBox(){
        dialogueBox.SetActive(false);
    }

    public void displayMessage(string message){
        t.text = "";
        dialogueArrow.SetActive(false);
        StartCoroutine(displayMessageMaker(message));
    }

    IEnumerator displayMessageMaker(string message){
        for(int i = 0; i < message.Length; i++){
            t.text = t.text + message[i];
            yield return new WaitForSeconds(0.1f);
        }
        dialogueArrow.SetActive(true);
    }
}
