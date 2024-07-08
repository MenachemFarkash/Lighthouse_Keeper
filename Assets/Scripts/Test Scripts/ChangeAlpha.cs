using UnityEngine;

public class ChangeAlpha : MonoBehaviour {
    Color color;
    MeshRenderer meshRenderer;
    public float alpha;
    // Start is called before the first frame update
    void Start() {
        alpha = 0;
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
        color = meshRenderer.material.color;
        meshRenderer.material.color = new Color(color.r, color.g, color.b, alpha);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.G)) {
            if (alpha < 1f)
                alpha += 0.1f;
            meshRenderer.material.color = new Color(color.r, color.g, color.b, alpha);
        }

        if (Input.GetKeyDown(KeyCode.H)) {
            if (alpha < 1f && alpha > 0f)
                alpha -= 0.1f;
            meshRenderer.material.color = new Color(color.r, color.g, color.b, alpha);
        }
    }
}
