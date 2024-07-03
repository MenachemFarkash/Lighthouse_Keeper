using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100f)) {
                print(hit.collider.name);
            }
        }
    }
}
