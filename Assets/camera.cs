using UnityEngine;

public class camera : MonoBehaviour
{
    
    Vector2 playerPos;
    Vector3 cameraPos;
    [SerializeField] private Camera _camera;
    public GameObject player;
    public player playerSize;

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
        _camera.orthographicSize = playerSize.playerSize;
        transform.position = cameraPos;
        
    }
}
