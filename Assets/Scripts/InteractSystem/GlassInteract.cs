using UnityEngine;

public class GlassInteract : Interactable {
    [SerializeField] GlassCleaningSystem cleaningSystem;
    public override void Interact() {
        base.Interact();

        cleaningSystem.isGettingCleaned = true;
    }
}
