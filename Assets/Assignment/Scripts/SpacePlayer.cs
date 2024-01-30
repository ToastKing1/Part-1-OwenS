using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacePlayer : MonoBehaviour
{

    public float speed = 2.5f;
    public GameObject lazerPrefab;
    public Transform lazerSpawn;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(lazerPrefab, lazerSpawn.position, lazerSpawn.rotation);
        }
    }
}
