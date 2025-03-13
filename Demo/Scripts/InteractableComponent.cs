using UnityEngine;

namespace WhiteArrow.Demo
{
    public class InteractableComponent : MonoBehaviour, IInteractable
    {
        public string DebugText;

        public void Interact()
        {
            Debug.Log($"Interacted with component: {this.name}");
        }
    }
}
