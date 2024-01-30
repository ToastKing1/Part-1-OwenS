using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseWall : MonoBehaviour
{
    public GameObject loseText;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        loseText.SetActive(true);
    }
}
