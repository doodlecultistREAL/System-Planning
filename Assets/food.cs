using System.Collections;
using Unity.VisualScripting;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.Rendering;

public class food : MonoBehaviour
{

    //the intent for this script is to spawn in food a random distance around the player
    //and to make it spin a little.

    public GameObject foodItem;
    public GameObject player;
    int startFood = 10;
    int foodCount = 0;
    float maxSpawnRange = 10f;
    float timer;
    float spawnTimer = 3;
    float decayTimer;
    bool timerOn = true;
    Vector2 playerPosition;
    Vector2 foodPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    

    }
   
    // Update is called once per frame
    void Update()
    {
        
        

        //when the game starts, spawn in fruits equal to the startFruits variable.
        //essentially populates the starting area while more fruits are waiting to spawn.
        while (foodCount < startFood)
        {

            foodCount += 1;
            OnFoodSpawn();

        }

        //starts the food spawning coroutine.
        if (timerOn == true) {

            StartCoroutine(FoodSpawn());

    }

    }

    //if there isn't a timer running, run the timer and spawn in a food item.
    //timer length is randomized.
    IEnumerator FoodSpawn()
    {
        timerOn = false;
        timer = Random.Range(1, spawnTimer);
        yield return new WaitForSeconds(timer);
        OnFoodSpawn();
        timerOn = true;
        StopCoroutine(FoodSpawn());
        
     
    }


    void OnFoodSpawn()
    {
        //spawn the food prefab.
        Instantiate(foodItem);

        //set the food position to be within a random range of the player by adding the randomized values and the player position together.
        foodPosition.x = Random.Range(-maxSpawnRange, maxSpawnRange);
        foodPosition.y = Random.Range(-maxSpawnRange, maxSpawnRange);

        foodItem.transform.position = foodPosition; 

      
        Debug.Log("food spawn");

    }
}
