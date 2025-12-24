// using UnityEngine;

// public class Attack2 : MonoBehaviour
// {
//     Animator anim;

//     void Start()
//     {
//         anim = GetComponent<Animator>();
//     }

//     void Update()
//     {
//         if (Input.GetMouseButtonDown(1)) // change this to hold left mouse button
//         {
//             anim.SetTrigger("Attack2");
//         }
//     }
// }


using UnityEngine;

public class Attack2 : MonoBehaviour
{
    public static bool IsHolding; // shared state

    Animator anim;
    float holdTime;
    public float holdThreshold = 0.25f;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            holdTime = 0f;
            IsHolding = false;
        }

        if (Input.GetMouseButton(0))
        {
            holdTime += Time.deltaTime;

            if (holdTime >= holdThreshold)
            {
                IsHolding = true;
                anim.SetBool("Attack2", true);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("Attack2", false);
            IsHolding = false;
        }
    }
}
