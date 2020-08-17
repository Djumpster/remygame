using UnityEngine;

public class AlignGraphicWithVelocity: MonoBehaviour
{    
    [SerializeField] private Transform graphic;
    [SerializeField] private Rigidbody2D rigidBody;

    protected void Update()
    {
        SetForward(rigidBody.velocity.x);
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
