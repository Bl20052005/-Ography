using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    /*
TLDR

Loads to a 'LoadScene" scene on CollisionEnter2d
U NEED TO set loadScene in the editor, transitionTime is just time for the fade effect to last

IN EACH SCENE WITH AT LEAST 1 SCENELOADER U WILL NEED the crossFade animation object,
 it should be attached as a child to whatever script this is attached to 

 if u have multiple sceneloaders, u still only need 1 crossfade animation item so in that case u dont
  need it as a child of this object, up 2 u tho

    */
    [SerializeField] Animator transition;
    [SerializeField] float transitionTime = 1f;
    [SerializeField] string loadScene;
    SpawnManager spawnManager;

    // Update is called once per frame
    void Awake()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            // if (Input.GetKey("e"))
            // {
            if (loadScene != null)
                LoadNextScene(loadScene); // Add in the scene name to the parameter.
                                          // }
        }
    }


    // Load the scene with the paramter as its name
    void LoadNextScene(string sceneName)
    {
        StartCoroutine(LoadAnimation(sceneName));
    }

    // Play the animation
    IEnumerator LoadAnimation(string sceneName)
    {
        // Play animation
        transition.SetTrigger("SceneStart");

        // Wait for animation to finish
        yield return new WaitForSeconds(transitionTime);

        // Load scene
        spawnManager.SetPrevScene();

        SceneManager.LoadScene(sceneName);
    }
}
