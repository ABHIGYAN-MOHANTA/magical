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
        // Hold to defend
        bool defending = Keyboard.current.spaceKey.isPressed;
        anim.SetBool("Defend", defending);
    }

    // Call this when enemy attack is blocked
    public void OnDefendHit()
    {
        anim.SetTrigger("DefendHit");
    }
}
