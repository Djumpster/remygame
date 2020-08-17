using UnityEngine;

public class GroundedChecker : MonoBehaviour
{
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private Transform[] groundedPoints;

    private bool isGrounded;

    public bool IsGrounded       
    {
        get
        {
            return CheckGrounded();
        }
    }

    private bool CheckGrounded()
    {
        foreach(Transform groundedPoint in groundedPoints)
        {
            Collider2D touchesGround = Physics2D.OverlapCircle(groundedPoint.position, .1f, whatIsGround);
            if (touchesGround != null)
            {
                return true;
            }
        }
        return false;
    }
}
