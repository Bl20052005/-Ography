using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    // Update is called once per frame
    void Update()
    {

        // Conditions for triggering the transition (currently space key)
        if (Input.GetKeyDown(KeyCode.Space)){
            LoadNextScene(""); // Add in the scene name to the parameter.
        }

    }

    // Load the scene with the paramter as its name
    public void LoadNextScene(string sceneName){
        StartCoroutine(LoadAnimation(sceneName));
    }

    // Play the animation
    IEnumerator LoadAnimation(string sceneName){
        // Play animation
        transition.SetTrigger("SceneStart");

        // Wait for animation to finish
        yield return new WaitForSeconds(transitionTime);

        // Load scene
        SceneManager.LoadScene(sceneName);
    }
}
