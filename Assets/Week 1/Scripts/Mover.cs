using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Mover : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Direction = Input.GetAxis("Horizontal");
        transform.Translate(Direction * speed * Time.deltaTime, 0, 0);
    }

}
