using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class spawnOnLoad : MonoBehaviour
{
    /*
    TLDR

This script sets the player's spawn location when loading into each scene, it is very tied to the SpawnManager.cs so see that too

basically, gets the player's prev scene and currently active scene to determine spawn Locations

SPAWNL+POINTS ARE SET IN SPAWNMANAGER, if u need spawnpoints, go there to add them

if u want to change this to a case switch for legibility instead of if-elses, pls do <3
    */
    [SerializeField] SpawnManager spawnManager;
    string activeScene;

    string prevScene;

    void Awake()
    {
        spawnManager = FindObjectOfType<SpawnManager>();

    }
    void Start()
    {



        if (spawnManager != null)

        {
            prevScene = spawnManager.GetPrevScene();
            activeScene = GetCurrentScene();
            Debug.Log(prevScene + " was the previous Scene");

            Debug.Log("deciding player spawn location: activeScene is " + activeScene + " and prevScene is " + prevScene);


            if (activeScene == "TownScene" && prevScene == "PlayerHouse")
            {
                Debug.Log("playerHouse to Town");
                Debug.Log(spawnManager.GetLocation(3));
                this.transform.position = spawnManager.GetLocation(3);
            }
            else if (activeScene == "TownScene" && prevScene == "NPC House 1")
            {
                Debug.Log(spawnManager.GetLocation(1));
                this.transform.position = spawnManager.GetLocation(1);
            }
            else if (activeScene == "TownScene" && prevScene == "Shop")
            {
                Debug.Log(spawnManager.GetLocation(2));
                this.transform.position = spawnManager.GetLocation(2);
            }
            else if (activeScene == "TownScene" && prevScene == "NPC House 2")
            {
                Debug.Log(spawnManager.GetLocation(4));
                this.transform.position = spawnManager.GetLocation(4);
            }
            else if (activeScene == "TownScene" && prevScene == "HiddenRoom")
            {
                this.transform.position = spawnManager.GetLocation(5);
            }
            else
            {
                this.transform.position = spawnManager.GetLocation(0);
            }
        }
    }


    string GetCurrentScene()
    {
        Debug.Log(SceneManager.GetActiveScene().name);
        return SceneManager.GetActiveScene().name;

    }
}
