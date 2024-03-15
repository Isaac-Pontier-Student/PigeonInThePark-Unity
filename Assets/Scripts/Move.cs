using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); //if there is an axis named Horizontal, horizontalInput will be set to that axis value (-1, 1) every frame.
        //input class must be static then if we can use it without an instance
        if (Input.GetKeyDown(KeyCode.Space)) //only returns true once when you press it
        {
            transform.localScale = Vector3.one;
        }
        if (Input.GetKey(KeyCode.Space)) //returns true when space bar held down
        {
            transform.localScale += Vector3.one * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space)) 
        {
            transform.localScale = Vector3.one;
        }
        transform.position += Vector3.forward * moveSpeed * horizontalInput * Time.deltaTime;
        //transform is a class that lives in the class MonoBehaviour that reflects data from Transform component. .position is an attribute in the transform class that
        //refers to the x y z coordinates, and we change those using the Vector3.forward thing (shorthand for (0, 0, 1)

        //console print input of a key press
    }
} 