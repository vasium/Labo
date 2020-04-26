using UnityEngine;
using Valve.VR.InteractionSystem;

namespace Woqomoqo.Athena.Laboratorium
{
    public interface IUnlockingObjectModifier
    {
        void DetachTransformFixedjoint(Interactable interactable, Transform lockTransform);
    }
}