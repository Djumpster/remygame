using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    [SerializeField] private BaseBullet bullet;
    [SerializeField] private LayerMask collisionLayers;

    public event System.Action<RaycastHit2D> OnBulletCollision = delegate {};

    private Vector3 previousPosition;

    protected void Start()
    {
        previousPosition = transform.position;
    }

    private void Update()
    {
        Vector3 currentPosition = transform.position;
        Vector3 traveled = currentPosition - previousPosition;
        RaycastHit2D hit = Physics2D.Raycast(previousPosition, traveled.normalized, traveled.magnitude, collisionLayers);        
        previousPosition = currentPosition;

        if (hit.collider != null)
        {            
            OnBulletCollision.Invoke(hit);
            Debug.Log("I hit " + hit.collider.gameObject);
            Debug.Break();
        }
    }
}
