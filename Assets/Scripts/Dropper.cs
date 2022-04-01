using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rbody;

    [SerializeField] private float timeToWait = 4f; // In Seconds

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        rbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            renderer.enabled = true;
            rbody.useGravity = true;
        }
    }
}