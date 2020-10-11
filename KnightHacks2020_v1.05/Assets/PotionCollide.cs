// This class waits for a collision between the potion and the cube inside the cauldron. Once triggered, we check the objects name and then instantiate a key.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionCollide : MonoBehaviour
{
    // The location the key spawns. It uses global coordinates.
    public Vector3 keySpawnLocation;
    // The key object that will be spawned. It will create a duplicate of the object, so place the real one outside the map.
    public GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Check for collision. Note that the object doing the triggering (i.e., the cube in the cauldron) must have "is Trigger" enabled in the collider component. 
    void OnTriggerEnter(Collider other) {
        print("Collision!");
        if (other.name == "Potion_Red(Clone)") {
            print("Spawning Key...");
            Instantiate(key, keySpawnLocation, Quaternion.identity);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
