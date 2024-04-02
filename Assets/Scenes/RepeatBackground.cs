using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x < startPos.x - 15)
        {
            print("AOOOOOO");
            transform.position = startPos;
        }
    }
}
