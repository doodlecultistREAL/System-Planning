using System.Net.NetworkInformation;
using UnityEngine;
using System.Collections;



public class FoodRunning : MonoBehaviour
{

   
    public food player;

    [SerializeField] private SpriteRenderer foodCollide;

    bool timerOn = true;
    float timer;
    float decayTimer = 20;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (foodCollide.bounds.Contains(player.player.transform.position))
        {

            Debug.Log("eaten");
            Destroy(gameObject);
        }

        if (timerOn == true)
        {

            StartCoroutine(FoodDespawn());

        }



    }

    //reuses the previous food spawning code. Makes a timer, and destroys the food object after it completes.
    IEnumerator FoodDespawn()
    {
        timerOn = false;
        timer = Random.Range(3, decayTimer);
        yield return new WaitForSeconds(timer);
        Destroy(gameObject);
     


    }

}
