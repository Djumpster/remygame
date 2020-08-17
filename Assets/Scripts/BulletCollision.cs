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

        if (hit.collider != null)
        {
            transform.position = hit.point;

            OnBulletCollision.Invoke(hit);
        }
    }
}
