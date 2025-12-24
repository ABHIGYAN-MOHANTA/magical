using UnityEngine;
using UnityEngine.InputSystem;

public class DefendInput : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Hold RIGHT mouse button to defend
        bool defending = Mouse.current != null &&
                         Mouse.current.rightButton.isPressed;

        anim.SetBool("Defend", defending);
    }

    // Call this when enemy attack is blocked
    public void OnDefendHit()
    {
        anim.SetTrigger("DefendHit");
    }
}
