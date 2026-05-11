using UnityEngine;

public class AutoScroll : MonoBehaviour
{
    [SerializeField] private Vector2 direction = Vector2.left;
    [SerializeField] private float speed = 1f;

    private void Update()
    {
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
