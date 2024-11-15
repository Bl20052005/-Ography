using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagKeyLogic : MonoBehaviour
{
    static bool key = false;
    static bool flag = false;
    private SpriteRenderer my_sprite;
    public Sprite flagSprite;
    public Sprite keySprite;
    // Start is called before the first frame update
    void Start()
    {
        my_sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool hasKey()
    {
        return key;
    }

    public bool hasFlag()
    {
        return flag;
    }

    public void getFlag()
    {
        flag = true;
        my_sprite.sprite = flagSprite;
    }

    public void getKey()
    {
        flag = false;
        key = true;
        my_sprite.sprite = keySprite;
    }
}
