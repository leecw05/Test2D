using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRoteateImage : MonoBehaviour
{
    // Start is called before the first frame update
    float rotSpeed;

    void Start()
    {
        Debug.Log("Hello, Wrold");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            rotSpeed = 10;
        }
        transform.Rotate(0, 0, this.rotSpeed);  
        rotSpeed *= 0.96f;  
    }
}
