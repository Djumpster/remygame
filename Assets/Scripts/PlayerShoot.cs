
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private BaseBullet bullet;

    [SerializeField] private Transform muzzle;


    protected void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    private void Fire ()
    {
        BaseBullet bulletGO = GameObject.Instantiate(bullet, muzzle.position, Quaternion.identity);
        bulletGO.SetVelocity(muzzle.forward);
    }
}
