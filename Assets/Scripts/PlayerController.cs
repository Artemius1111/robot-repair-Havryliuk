using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction MoveAction;
    private float speed = 5.0f;

    void Start()
    {
        MoveAction.Enable();
    }

    void Update()
    {
        Vector2 move = MoveAction.ReadValue<Vector2>();

        Vector2 position = (Vector2)transform.position + move * speed * Time.deltaTime;
        transform.position = position;
    }
}