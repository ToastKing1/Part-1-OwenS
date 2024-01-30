using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float speed = 1000.0f;
    public Rigidbody2D body;
    Vector2 direction;

    void Start()
    {
        direction.x = 25;
        direction.y = 0;
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        body.AddForce(direction * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            Destroy(gameObject);
    }
}
