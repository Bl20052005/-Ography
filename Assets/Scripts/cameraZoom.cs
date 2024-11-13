using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cameraZoom : MonoBehaviour
{

    Camera camera;
    [SerializeField] Animator transition;
    [SerializeField] float transitionTime = 1f;
    [SerializeField] string loadScene;
    bool isWait = false;

    // Start is called before the first frame update
    void Awake()

    {
        camera = GetComponent<Camera>();
    }

    void Start()
    {
        Debug.Log("running start");
        if (!isWait)
            StartCoroutine(panCamera());

    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("Running update loop");
        if (camera.orthographicSize > 5.0f && isWait)
        {

            camera.orthographicSize -= .03f;
        }

        if (camera.orthographicSize <= 5.0)
            StartCoroutine(LoadAnimation(loadScene));


    }

    IEnumerator panCamera()
    {

        Debug.Log("Inenumerator called");
        yield return new WaitForSecondsRealtime(3f);
        Debug.Log("Inenumerator time passed");
        isWait = true;

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
