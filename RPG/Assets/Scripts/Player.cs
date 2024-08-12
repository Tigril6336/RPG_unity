using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float movSpeed = 10f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        Vector2 inputVector = GameInput.Instance.GetMovementVector();
        rb.MovePosition(rb.position + inputVector.normalized * (movSpeed * Time.fixedDeltaTime));
    }
}
