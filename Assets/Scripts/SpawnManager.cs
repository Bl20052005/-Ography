using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{

    List<Vector2> spawnList = new List<Vector2>();

    [SerializeField] static string prevScene;
    [SerializeField] GameObject Player;
    public static SpawnManager instance { get; private set; }

    void Awake()
    {
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy(this);

        DontDestroyOnLoad(this);


        InitializeSpawnPoints();
        Instantiate(Player);

        Debug.Log(prevScene + " HEHEHHEHEHEHEHEHEHEHEHEH");

    }
    void InitializeSpawnPoints()
    {

        spawnList.Add(new Vector2(0f, 0f));                             // 0
                                                                        // Lets make 1 room scenes default entrance be at 0,0
                                                                        // TOEWN SPAWN POINTS:

        spawnList.Add(new Vector2(3.47f, -7f)); // town npc house 1        1
        spawnList.Add(new Vector2(3.34f, -12.44f)); // town shop           2
        spawnList.Add(new Vector2(-8.8f, 5.54f)); // town PlayerHouse      3
        spawnList.Add(new Vector2(-22.64f, -7.16f)); // town npc house 2   4
        spawnList.Add(new Vector2(26.02f, 4.22f)); // town hiddenRoom      5
    }
    public Vector2 GetLocation(int index)
    {
        return spawnList[index];
    }
    public void addLocation(Vector2 location)
    {
        spawnList.Add(location);
    }
    public void SetPrevScene()
    {
        prevScene = SceneManager.GetActiveScene().name;
        Debug.Log("PREV SCENE IS BEING LOADED INTO" + prevScene);

    }
    public string GetPrevScene()
    {
        return prevScene;

    }



}

