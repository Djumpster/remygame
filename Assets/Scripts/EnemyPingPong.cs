using UnityEngine;

public class EnemyPingPong : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private Rigidbody2D rigidBody;
    [SerializeField] private WallChecker wallChecker;

    [SerializeField] private Transform graphic;

    private float moveDirection = 1f;


    void Update()
    {        
        float velocity_x = GetHorizontalVelocity();
        rigidBody.velocity = new Vector2(velocity_x, rigidBody.velocity.y);       
    }

    private float GetHorizontalVelocity()
    {
        if (wallChecker.TouchesWall)
        {
            moveDirection *= -1f;
        }

        return moveDirection * moveSpeed;
    }
}
