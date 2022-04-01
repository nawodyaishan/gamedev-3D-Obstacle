using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits = -1;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++; // hits = hits + 1
            Debug.Log("You Bumped in to a thing: " + hits + " Times");
        }
    }
}
