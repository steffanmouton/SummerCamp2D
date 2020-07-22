using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    private Transform player;
    public float itemOffset = 3f;

    // Start is called before the first frame update
    void Start()
    { 
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    public void SpawnDroppedItem()
    {
        // Pick a side to spawn the item. 0 is left, 1 is right.
        int side = Random.Range(0, 2);

        // Randomize distance to spawn
        itemOffset = Random.Range(1, 4);

        if (side == 0)
        {
            Vector2 playerPos = new Vector2(player.position.x - itemOffset, player.position.y);
            Instantiate(item, playerPos, Quaternion.identity);
        }
        else
        {
            Vector2 playerPos = new Vector2(player.position.x + itemOffset, player.position.y);
            Instantiate(item, playerPos, Quaternion.identity);
        }


        
    }
}
