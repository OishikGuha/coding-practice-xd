using System;
using UnityEngine;

public class Person
{

    float speed;
    float xMov;
    float yMov;

    public Person(Sprite personSprite, float speed, SpriteRenderer sr, Rigidbody2D rb)
    {
        if (personSprite != null)
        {
            float xMov = Input.GetAxisRaw("Horizontal");
            float yMov = Input.GetAxisRaw("Vertical");

            this.speed = speed;
            this.xMov = xMov;
            this.yMov = yMov;

            sr.sprite = personSprite;
        }

        PersonMove(rb);
    }

    public void PersonMove(Rigidbody2D rb)
    {
        rb.velocity = new Vector3(xMov, yMov) * speed * Time.deltaTime;
    }
}
