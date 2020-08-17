using UnityEngine;

public class WallChecker : MonoBehaviour
{
    [SerializeField] private LayerMask whatIsWall;
    [SerializeField] private Transform[] wallPoints;

    public bool TouchesWall       
    {
        get
        {
            return CheckWall();
        }
    }

    private bool CheckWall()
    {
        foreach(Transform wallPoint in wallPoints)
        {
            Collider2D touchesWall = Physics2D.OverlapCircle(wallPoint.position, .1f, whatIsWall);
            if (touchesWall != null)
            {
                return true;
            }
        }
        return false;
    }
}
