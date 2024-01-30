using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawn : MonoBehaviour
{
    public float Timer = 0.0f;
    public GameObject meteorPrefab;
    public Transform meteorSpawn;

    // Update is called once per frame
    void Update()
    {
        Timer += 0.1f * Time.deltaTime;
        if (Timer > 1.0f)
        {
            Instantiate(meteorPrefab, meteorSpawn);
            Timer = 0.0f;
        }
    }
}
