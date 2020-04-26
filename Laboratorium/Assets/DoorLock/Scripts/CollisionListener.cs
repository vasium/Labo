using UnityEngine;

namespace Woqomoqo.Athena.Laboratorium
{
    public class CollisionListener : MonoBehaviour, ICollisionManager
    {
        public GameObject unlockingObject;
        public event ObjectCollided ObjectCollided;

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject == unlockingObject)
            {
                ObjectCollided(unlockingObject);
            }
        }
    }
}