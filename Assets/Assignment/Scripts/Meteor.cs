using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float speed = -0.5f;
    public Rigidbody2D body;

    void Start()
    {
        Vector2 boost = transform.right;
        body.AddForce(-boost * Time.deltaTime * 20);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            Destroy(gameObject);
    }
}
