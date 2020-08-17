
using UnityEngine;

public interface IBullet
{
    void SetVelocity(Vector3 velocity);

    Vector3 Velocity { get; }
}
