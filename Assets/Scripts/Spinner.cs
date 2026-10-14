using UnityEngine;

public class Spinner : MonoBehaviour
{
    [Tooltip("Velocidad de giro de la moneda")]
    public float speed = 100f;

    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}