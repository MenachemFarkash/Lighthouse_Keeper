using UnityEngine;

public class GlassCleaningSystem : MonoBehaviour {
    Color color;
    MeshRenderer meshRenderer;
    public float alpha;
    public float timeUntilDirty = 300f;
    public float timeUntilClean = 15f;
    public bool isGettingCleaned = false;
    // Start is called before the first frame update
    void Start() {
        alpha = 0;
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
        color = meshRenderer.material.color;
        meshRenderer.material.color = new Color(color.r, color.g, color.b, alpha);
    }

    void Update() {


        if (!isGettingCleaned) {

            GetDirtyOverTime();
        } else {
            CleanGlass();
        }

        if (alpha == 0) {
            isGettingCleaned = false;
        }
    }

    public void GetDirtyOverTime() {
        if (alpha < 1f) {
            float alphaIncreasePerSecond = 1f / timeUntilDirty;
            alpha += alphaIncreasePerSecond * Time.deltaTime;
            alpha = Mathf.Clamp(alpha, 0f, 1f); // Ensure alpha does not exceed 1f
            meshRenderer.material.color = new Color(color.r, color.g, color.b, alpha);
        }
    }

    public void CleanGlass() {
        isGettingCleaned = true;
        float alphaDecreasePerSecond = 1f / timeUntilClean;
        alpha -= alphaDecreasePerSecond * Time.deltaTime;
        alpha = Mathf.Clamp(alpha, 0f, 1f); // Ensure alpha does not exceed 1f
        meshRenderer.material.color = new Color(color.r, color.g, color.b, alpha);
    }
}
