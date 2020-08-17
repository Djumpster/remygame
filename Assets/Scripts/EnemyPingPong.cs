using UnityEngine;

public class EnemyPingPong : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private Rigidbody2D rigidBody;
    [SerializeField] private GroundedChecker groundedChecker;

    [SerializeField] private Transform graphic;

    private float moveDirection = 1f;


    void Update()
    {
        float input = 1f;

        float velocity_x = GetHorizontalVelocity();
        rigidBody.velocity = new Vector2(velocity_x, rigidBody.velocity.y);
        SetForward(velocity_x);
    }

    private float GetHorizontalVelocity()
    {
        return moveDirection * moveSpeed;
    }

    private void SetForward(float velocity)
    {
        if (velocity > 0f)
        {
            graphic.forward = Vector3.right;
        }
        if (velocity < 0f)
        {
            graphic.forward = Vector3.left;
        }
    }
}
