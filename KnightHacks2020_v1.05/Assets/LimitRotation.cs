// This class checks for when the torch is rotated enough, and if so it enables the script TorchRotate. There's definently a better way to do this, but it works.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitRotation : MonoBehaviour
{
    // The amount of rotation needed to trigger the bookcase.
    public float rotationAngle;
    public TorchRotate torch;
    // Use this for initialization
    void Start()
    {
        // Get the Component called TorchRotate from this torch, and set it to disabled. That way we can enable it when its time to do it 
        torch = GetComponent<TorchRotate>();
        torch.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // For some reason the x value of the torch in the editor isn't the same here, I've set the torch to activate the TorchRotated script once it has rotated to x = -110,
        // and that translates to 280 here. Use print(transform.rotation.eulerAngles.x) above the if statement to see the real rotation value. I put 280 in the rotationAngle field in the inspector.
        if (transform.rotation.eulerAngles.x >= rotationAngle) {
            // If torch has been rotated enough, enable the Torch Rotate script. It will immediately begin moving the bookcase.
            torch.enabled = true;
        }
    }
}