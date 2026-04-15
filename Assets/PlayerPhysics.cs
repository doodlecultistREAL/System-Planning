using UnityEditor.Build;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    public Transform ball;
    public Vector2 ballPos;
    public Vector2 velocity;
    public float accel;
    float friction = 1.05f;
    public SpriteRenderer collide;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballPos = transform.position;
       
        velocity.x = -1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = ballPos;
    


        accel /= friction;

        ballPos += (velocity * accel) * Time.deltaTime;


        if (collide.bounds.Contains(ballPos))
        {

            velocity *= -1;


        }
       

    }
}
