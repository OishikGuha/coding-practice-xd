using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonDisplay : MonoBehaviour
{
    public Sprite sprite;
    public float speed;
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D prigidbody;

    // Update is called once per frame
    void Update()
    {
        Person person = new Person(sprite, speed, spriteRenderer, prigidbody);
    }
}
