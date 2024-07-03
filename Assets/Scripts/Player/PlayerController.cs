using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Interactable interactable;
    [SerializeField] GameObject interactPromptPanel;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update() {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 5f)) {
            print(hit.collider.name);
            if (hit.collider.gameObject.GetComponent<Interactable>()) {
                interactable = hit.collider.gameObject.GetComponent<Interactable>();
                interactPromptPanel.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E) && hit.collider != null) {
                    interactable.Interact();
                }

            } else {
                interactPromptPanel.SetActive(false);
            }
        } else {
            interactPromptPanel.SetActive(false);
        }

    }
}
