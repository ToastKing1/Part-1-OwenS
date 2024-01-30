using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseWall : MonoBehaviour
{
    public GameObject loseText;

    Boolean Lose = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Lose = true;
    }
}
