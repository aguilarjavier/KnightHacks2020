using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class ChestTrigger : MonoBehaviour
{
    public GameObject Chest;
    public GameObject Chest_Open;
    public GameObject redPotion;
    public GameObject bluePotion;
    public GameObject greenPotion;
    public Vector3 ChestSpawn;
    public Vector3 redPotionSpawn;
    public Vector3 bluePotionSpawn;
    public Vector3 greenPotionSpawn;


    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Key_Silver")
        {
            Vector3 chestPosition = Chest.transform.position;
            Destroy(Chest);
            Chest_Open.transform.position = chestPosition;
            Instantiate(redPotion, redPotionSpawn, Quaternion.identity);
            Instantiate(bluePotion, bluePotionSpawn, Quaternion.identity);
            Instantiate(greenPotion, greenPotionSpawn, Quaternion.identity);

        }
    }

  
}
