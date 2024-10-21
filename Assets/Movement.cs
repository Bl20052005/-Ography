using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D realBody;
    private Vector2 vdirection;
    public int speed; 
    // Start is called before the first frame update
    void Start()
    {
        realBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        vdirection = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        
    }

    void FixedUpdate(){
        realBody.velocity = vdirection * speed;
    }

}   

