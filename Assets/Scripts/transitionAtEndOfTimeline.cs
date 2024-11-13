using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class transitionAtEndOfTimeline : MonoBehaviour
{
    /*tldr

    once the transition animation finishes, switch to the next scene
    */
    PlayableDirector playableDirector;

    [SerializeField] Animator transition;
    [SerializeField] float transitionTime = 1f;
    [SerializeField] string loadScene;
    // Start is called before the first frame update

    void Awake()
    {
        playableDirector = GetComponent<PlayableDirector>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playableDirector.state == PlayState.Paused)
        {
            StartCoroutine(LoadAnimation(loadScene));
        }
    }

    IEnumerator LoadAnimation(string sceneName)
    {
        // Play animation
        transition.SetTrigger("SceneStart");

        // Wait for animation to finish
        yield return new WaitForSeconds(transitionTime);

        // Load scene
        SceneManager.LoadScene(sceneName);
    }

}
