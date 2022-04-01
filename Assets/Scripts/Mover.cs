using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script for Player Object
/// </summary>
public class Mover : MonoBehaviour
{
    
    // Speed Multiplier
    [SerializeField]private float speedMultiplier = 10.0f;
    
    // Variables for moving the object
    //[SerializeField] private float xValue = 0.0f;
   //[SerializeField] private float yValue = 0.0f;
    //[SerializeField] private float zValue = 0.0f;
    
    //private const string X_AXIS = "Horizontal";
    //private const string Y_AXIS = "Vertical";
    //private const string Z_AXIS = "Jump";

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speedMultiplier;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speedMultiplier;
        //float zValue = Input.GetAxis(Z_AXIS);
        transform.Translate(xValue, 0, zValue);
    }
}