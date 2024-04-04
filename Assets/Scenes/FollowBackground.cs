using UnityEngine;

public class FollowBackground : MonoBehaviour
{
    public Transform backgroundTransform;

    private Vector3 offset;

    void Start()
    {
        // Calcola l'offset iniziale tra la posizione della camera e la posizione dello sfondo
        offset = transform.position - backgroundTransform.position;
    }

    void LateUpdate()
    {
        // Aggiorna la posizione della camera in base allo sfondo
        transform.position = backgroundTransform.position + offset;
    }
}
