using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetEverything : MonoBehaviour
{

    /*
    reset static variables and other things to default when reloading/ resetting the game


    */

    HasKey hasKey;
    DestroyOnCollected destroyOnCollected;



    void ResetAll()
    {
        hasKey.ResetAllVals();
        destroyOnCollected.ResetAllVals();

    }
}
