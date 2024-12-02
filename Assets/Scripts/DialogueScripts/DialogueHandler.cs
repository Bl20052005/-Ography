using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueHandler : MonoBehaviour
{
   [SerializeField] private Text nameText;
   [SerializeField] private Text dialogueText;
   [SerializeField] private GameObject dialogueBox;
   private bool dialogueOccuring;


   private Queue<string> sentences;
   private Queue<string> names;


   void Start(){
        sentences = new Queue<string>();
        names = new Queue<string>();
        RemoveDialogueBox();
   }


   public void StartDialogue(Dialogue dialogue){
        ShowDialogueBox();

        sentences.Clear(); 
        foreach(string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);
        }

        names.Clear(); 
        foreach(string name in dialogue.names){
            names.Enqueue(name);
        }

        DisplayNextSentence();
   }

   public void DisplayNextSentence(){
        if(sentences.Count == 0){
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        string name = names.Dequeue();
        StartCoroutine(DisplayMessageMaker(sentence, name));
   }




   private void EndDialogue(){
        sentences.Clear();
        RemoveDialogueBox();
   }

   private void ShowDialogueBox(){
       dialogueBox.SetActive(true);
   }

   private void RemoveDialogueBox(){
       dialogueBox.SetActive(false);
   }


   IEnumerator DisplayMessageMaker(string message, string name){
        dialogueText.text = "";
        nameText.text = name;
        for(int i = 0; i < message.Length; i++){
            dialogueText.text = dialogueText.text + message[i];
            yield return new WaitForSeconds(0.05f);
        }
   }
}



