using UnityEngine;

public class ParallaxLayer : MonoBehaviour
{
    [SerializeField] private Transform targetCamera;
    [SerializeField] private float parallaxMultiplier = 0.5f;

    private Vector3 lastCameraPosition;

    private void Start()
    {
        if (targetCamera == null)
        {
            targetCamera = Camera.main.transform;
        }

        lastCameraPosition = targetCamera.position;
    }

    private void LateUpdate()
    {
        Vector3 deltaMovement = targetCamera.position - lastCameraPosition;

        transform.position += new Vector3(
            deltaMovement.x * parallaxMultiplier,
            deltaMovement.y * parallaxMultiplier,
            0f
        );

        lastCameraPosition = targetCamera.position;
    }
}
