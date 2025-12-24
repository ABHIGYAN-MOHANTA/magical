using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotation : MonoBehaviour
{
    public float mouseSensitivity = 0.15f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Mouse.current == null) return;

        float mouseX = Mouse.current.delta.ReadValue().x;

        // rotate player horizontally
        transform.Rotate(Vector3.up * mouseX * mouseSensitivity);
    }
}
