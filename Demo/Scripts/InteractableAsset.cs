using UnityEngine;

namespace WhiteArrow.Demo
{
    public class InteractableAsset : ScriptableObject, IInteractable
    {
        public void Interact()
        {
            Debug.Log($"Interacted with asset: {this.name}");
        }
    }
}
