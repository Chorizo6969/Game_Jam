using UnityEngine;

public class Earthquake : MonoBehaviour
{
    public float shakeMagnitude = 3f;
    public float shakeSpeed = 3f;

    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        float x = originalPosition.x + Random.Range(-shakeMagnitude, shakeMagnitude);//Mouvement de la cam sur l'axe x selon la variable shakeMagnitude
        float y = originalPosition.y + Random.Range(-shakeMagnitude, shakeMagnitude);//Mouvement de la cam sur l'axe y selon la variable shakeMagnitude
        float z = originalPosition.z + Random.Range(-shakeMagnitude, shakeMagnitude);//Mouvement de la cam sur l'axe z selon la variable shakeMagnitude

        transform.position = Vector3.Lerp(transform.position, new Vector3(x, y, z), Time.deltaTime * shakeSpeed);
    }
}