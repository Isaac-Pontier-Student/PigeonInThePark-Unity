using System.Collections;
using System.Collections.Generic;
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
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //transform is a class that lives in the class MonoBehaviour that reflects data from Transform component. .position is an attribute in the transform class that
        //refers to the x y z coordinates, and we change those using the Vector3.forward thing (shorthand for (0, 0, 1)
        transform.localScale += Vector3.one * Time.deltaTime;
    }
}