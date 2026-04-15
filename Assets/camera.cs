using UnityEngine;

public class camera : MonoBehaviour
{
    
    Vector2 playerPos;
    Vector3 cameraPos;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        cameraPos.z = transform.position.z;
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraPos.x = player.transform.position.x;
        cameraPos.y = player.transform.position.y;

        transform.position = cameraPos;
        
    }
}
