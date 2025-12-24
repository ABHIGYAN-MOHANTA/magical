using UnityEngine;
using UnityEngine.InputSystem;

public class WizardMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 720f;

    Animator anim;
    CharacterController controller;

    void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
{
    float x = 0f;
    float y = 0f;

    // WASD input
    if (Keyboard.current.aKey.isPressed) x = -1f;
    if (Keyboard.current.dKey.isPressed) x = 1f;
    if (Keyboard.current.wKey.isPressed) y = 1f;
    if (Keyboard.current.sKey.isPressed) y = -1f;

    // Send to Animator
    anim.SetFloat("MoveX", x);
    anim.SetFloat("MoveY", y);

    // Movement vector (local space)
    Vector3 move = transform.forward * y + transform.right * x;

    // Rotate ONLY when moving forward or backward
    if (Mathf.Abs(y) > 0.1f)
    {
        Quaternion targetRotation = Quaternion.LookRotation(transform.forward);
        transform.rotation = Quaternion.RotateTowards(
            transform.rotation,
            targetRotation,
            rotationSpeed * Time.deltaTime
        );
    }

    // Move character
    controller.Move(move.normalized * moveSpeed * Time.deltaTime);
}

}
