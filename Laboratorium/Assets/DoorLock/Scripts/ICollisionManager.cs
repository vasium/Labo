using UnityEngine;

namespace Woqomoqo.Athena.Laboratorium
{
    public interface ICollisionManager
    {
        event ObjectCollided ObjectCollided;
    }

    public delegate void ObjectCollided(GameObject collidedObject);
}