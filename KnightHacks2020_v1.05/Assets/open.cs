using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class open : MonoBehaviour
{

	void OnTriggerEnter (Collider other)
	{
		if (other.name == "gold_key(Clone)")
		{
			print("hooray");
			Destroy (gameObject);
		}

		print("test");
	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
