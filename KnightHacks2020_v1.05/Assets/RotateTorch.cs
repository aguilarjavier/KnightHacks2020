using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTorch : MonoBehaviour
{
    public GameObject torch;
    public TorchRotate torchscript;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = torch.GetComponent<Animator>();
        torchscript.enabled = false;
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.name == "RightHand Controller" || other.name == "LeftHand Controller")
        {
            anim.SetTrigger("Begin");
            torchscript.enabled = true;
        }
        
        

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
