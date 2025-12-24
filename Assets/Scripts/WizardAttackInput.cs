using UnityEngine;
using System.Collections;

public class WizardAttackInput : MonoBehaviour
{
    public Animator animator;
    public SpellCaster spellCaster;
    public Camera playerCamera;

    public float castDelay = 0.3f;

    private bool isCasting = false;

    void Start()
    {
        if (!playerCamera)
            playerCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isCasting)
        {
            StartCoroutine(CastRoutine());
        }
    }

    IEnumerator CastRoutine()
    {
        isCasting = true;

        animator.SetTrigger("Attack");

        yield return new WaitForSeconds(castDelay);

        // ✅ SAME logic as your old working code
        Vector3 direction = playerCamera.transform.forward;
        direction.y = 0f;
        direction.Normalize();

        spellCaster.CastSpell(direction);

        isCasting = false;
    }
}
