using UnityEngine;

public class ParallaxInfinito : MonoBehaviour
{
    [SerializeField] private Transform targetCamera;
    //[SerializeField, Range(0f, 1f)] private float efectoParallax = 0.5f;
    [SerializeField, Range(-1f, 1f)] private float efectoParallax = 0.5f;

    [Header("Configuración de Bucle")]
    [Tooltip("El ancho de una sola copia de tu imagen de fondo")]
    [SerializeField] private float longitudSprite = 20f;

    private float posicionInicial;

    private void Start()
    {
        if (targetCamera == null) targetCamera = Camera.main.transform;

        posicionInicial = transform.position.x;
    }

    private void LateUpdate()
    {
        // Cuánto se ha movido la cámara en el espacio del mundo real
        float distanciaTemporal = targetCamera.position.x * (1 - efectoParallax);

        // Cuánto debe moverse el fondo visualmente
        float distanciaParallax = targetCamera.position.x * efectoParallax;

        // Aplicamos el movimiento
        transform.position = new Vector3(posicionInicial + distanciaParallax, transform.position.y, transform.position.z);

        // Lógica de repetición infinita basada en tu longitud manual
        if (distanciaTemporal > posicionInicial + longitudSprite)
        {
            posicionInicial += longitudSprite;
        }
        else if (distanciaTemporal < posicionInicial - longitudSprite)
        {
            posicionInicial -= longitudSprite;
        }
    }
}
