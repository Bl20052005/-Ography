using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    /* TLDR

    This is a Singleton to maintain spawnPoints for the player across different Scenes


    basically spawns the player, and then lets spawnOnLoad determine the coordinates to put the player

    it Maintains a list of Vector2 positions as different spawn points, see below for details

    also has a GetLocation(int), setPrevScene(string) and getPrevScene()

    this is a bit wwonky but 
    spawnOnLoad.cs has the actual logic for where to spawn the player, currently the logic works by checking the
    scene to load into and the prev scene we are coming from, and sets spawnpoints based on that
    Unfortunately the spawnPoints are just magic numbers as of now (0 ,1 , 2, 3) see below for them

    IF YOU MAKE A SCENE WITH 2 EXITS BACK TO THE SAME SCENE THIS WILL PROB NOT WORK SO work around that
    or fix my spaghetti sorry aha aha

    */
    [SerializeField] List<GameObject> spawnList = new List<GameObject>();

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

        Debug.Log(prevScene + " is the prevScene");

    }
    void InitializeSpawnPoints()
    {
        /*
                spawnList.Add(new Vector2(0f, 0f));                             // 0
                                                                                // Lets make 1 room scenes default entrance be at 0,0
                                                                                // TOWN SPAWN POINTS:

                spawnList.Add(new Vector2(3.15f, -7.3f)); // town npc house 1        1
                spawnList.Add(new Vector2(3f, -21f)); // town shop                   2
                spawnList.Add(new Vector2(-9.03f, 5.4f)); // town PlayerHouse        3
                spawnList.Add(new Vector2(-22.6f, -21f)); // town npc house 2        4
                spawnList.Add(new Vector2(10f, 1f)); //  town hiddenRoom             5

                */

    }
    public Vector2 GetLocation(int index)
    {
        Vector2 location = new Vector2(spawnList[index].transform.position.x, spawnList[index].transform.position.y);
        return location;
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

