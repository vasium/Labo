using UnityEngine;
using Valve.VR.InteractionSystem;

namespace Woqomoqo.Athena.Laboratorium
{
    public partial class LockManager : MonoBehaviour
    {

        [SerializeField]
        private Transform lockPosition;

        private IUnlockingObjectModifier unlockingObjectModifier;
        private ICollisionManager collisionManager;
        private Interactable interactable;

        private void Awake()
        {
            if (unlockingObjectModifier == null)
                unlockingObjectModifier = GetComponent<IUnlockingObjectModifier>();

            if (collisionManager == null)
                collisionManager = GetComponent<ICollisionManager>();
        }

        private void OnEnable()
        {
            collisionManager.ObjectCollided += CreateJointToCollidedObject;
        }

        private void CreateJointToCollidedObject(GameObject collidedObject)
        {
            interactable = collidedObject.GetComponent<Interactable>();

            if (interactable == null) return;

            if (interactable.attachedToHand == null) return;

            unlockingObjectModifier.DetachTransformFixedjoint(interactable, lockPosition);
        }
    }
}