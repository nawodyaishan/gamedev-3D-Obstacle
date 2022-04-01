using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float xAngle = 1;
    [SerializeField] private float yAngle = 1;
    [SerializeField] private float zAngle = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle); 
    }
}
