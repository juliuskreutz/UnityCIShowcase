using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;

    private InputAction _moveAction;

    private void Start()
    {
        _moveAction = InputSystem.actions.FindAction("Move");
    }

    private void Update()
    {
        var moveInput = _moveAction.ReadValue<Vector2>();

        if (moveInput == new Vector2(0, 0)) return;

        transform.Translate(Time.deltaTime * speed * new Vector3(moveInput.x, 0, moveInput.y));
    }
}