using UnityEngine;

public class LoopBackground : MonoBehaviour
{
    [SerializeField] private Transform targetCamera;
    [SerializeField] private float spriteWidth = 20f;
    [SerializeField] private float distance;

    private void Start()
    {
        if (targetCamera == null)
        {
            targetCamera = Camera.main.transform;
        }
    }

    private void Update()
    {
        distance = targetCamera.position.x - transform.position.x;

        if (distance >= spriteWidth)
        {
            Debug.Log("Looping background");
            transform.position += Vector3.right * spriteWidth * 2f;
        }
    }
}
