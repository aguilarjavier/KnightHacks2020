// This class does the rotation of the bookcase. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchRotate : MonoBehaviour
{
    public Vector3 rotationDirection;
    public float smoothTime;
    private float convertedTime = 200;
    private float smooth;
    public GameObject bookcaseParent;

    // Use this for initialization
    void Start()
    {
    }

    void rotate()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        // Keep rotating until the bookcase is 90 degrees turned.
        if (bookcaseParent.transform.rotation.eulerAngles.y < 90)
        {
            // Using smooth lets us control the speed of the rotation.
            smooth = Time.deltaTime * smoothTime * convertedTime;
            bookcaseParent.transform.Rotate(rotationDirection * smooth);
        }
        
    }
}
