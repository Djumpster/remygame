using System;
using UnityEngine;

public class BulletSolidify : MonoBehaviour
{
    [SerializeField] private BaseBullet bullet;
    [SerializeField] private BulletCollision collision;
    [SerializeField] private GameObject spawnOnCollision;

    protected void OnEnable()
    {
        collision.OnBulletCollision -= OnBulletCollisionEvent;
        collision.OnBulletCollision += OnBulletCollisionEvent;
    }

    protected void OnDisable()
    {
        collision.OnBulletCollision -= OnBulletCollisionEvent;
    }

    private void OnBulletCollisionEvent(RaycastHit2D obj)
    {
        GameObject platform = GameObject.Instantiate(spawnOnCollision, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(gameObject);
    }
}
