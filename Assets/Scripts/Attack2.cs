using UnityEngine;

public class Attack2 : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            anim.SetTrigger("Attack2");
        }
    }
}
