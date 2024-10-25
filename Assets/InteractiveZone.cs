using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveZone : MonoBehaviour
{
    private Movement player;
    private FlagKeyLogic fklogic;
    private bool checkE = false;
    private bool inZone = false;

    // Start is called before the first frame update
    void Start()
    {
        //Replace "Player" with the tag of whatever the player's tag is
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>();
        fklogic = GameObject.FindGameObjectWithTag("FKLogic").GetComponent<FlagKeyLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && inZone){
            checkE = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision){
        //If player is in the area and press E, call
        inZone = true;
        if (checkE && inZone){
            if(!fklogic.hasFlag() && !fklogic.hasKey()){
                fklogic.getFlag();
                checkE = false;
            }else if(!fklogic.hasFlag() && fklogic.hasKey()){
                
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        //If player is in the area and press E, call
        inZone = false;
        
    }
}
