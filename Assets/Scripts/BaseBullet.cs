
using UnityEngine;

public class BaseBullet : MonoBehaviour, IBullet
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Transform graphic; 


    public Vector3 Velocity { get; private set; }

    public void SetVelocity(Vector3 velocity)
    {
        Velocity = velocity.normalized * moveSpeed;
    }

    protected void Update()
    {
        transform.position += Time.deltaTime * Velocity;        
        graphic.localScale = new Vector3(Mathf.Sign(Velocity.x), 1f, 1f);
    }
}
