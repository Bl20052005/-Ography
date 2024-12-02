using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D player;
    [SerializeField] bool canMove = true;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {

        if (canMove)
            Move();

    }
    void Move()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
            transform.Rotate(0,0,speed*200*Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
            transform.Rotate(0,0,-speed*200*Time.deltaTime);
        }
        transform.position = pos;
    }


    public void disableMovement()
    {
        canMove = false;
    }
    public void enableMovement()
    {
        canMove = true;
    }

    private void FixedUpdate() { }

}
