using UnityEngine;
using Valve.VR.InteractionSystem;

namespace Woqomoqo.Athena.Laboratorium
{
    public class AttachmentCreator : MonoBehaviour, IUnlockingObjectModifier
    {
        public Rigidbody connectedBody;
        public float breakForce = Mathf.Infinity;
        public float breakTorque = Mathf.Infinity;
        public bool enableCollision = false;
        public bool enablePreprocessing = true;
        public float massScale = 1;
        public float connectedMassScale = 1;

        public void DetachTransformFixedjoint(Interactable interactable, Transform lockTransfor)
        {
            interactable.attachedToHand.DetachObject(interactable.gameObject);
            interactable.transform.position = lockTransfor.position;
            interactable.transform.eulerAngles = lockTransfor.eulerAngles;
            var joint = interactable.gameObject.AddComponent<FixedJoint>();
            joint.breakForce = breakForce;
            joint.breakTorque = breakTorque;
            joint.enableCollision = enableCollision;
            joint.enablePreprocessing = enablePreprocessing;
            joint.massScale = massScale;
            joint.connectedMassScale = connectedMassScale;
        }
    }
}
