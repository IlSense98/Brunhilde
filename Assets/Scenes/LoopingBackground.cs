using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRenderer;
    private Vector2 originalOffset;

    void Start()
    {
        // Memorizza l'offset originale della texture
        originalOffset = backgroundRenderer.material.mainTextureOffset;
    }

    void Update()
    {
        // Muovi lo sfondo
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);

        // Se lo sfondo si sposta oltre la larghezza della texture, riportalo indietro
        if (backgroundRenderer.material.mainTextureOffset.x >= 0f)
        {
            backgroundRenderer.material.mainTextureOffset = originalOffset;
        }
    }
}
