using UnityEngine;

public class SpellCaster : MonoBehaviour
{
    public Transform spellSpawnPoint;
    public GameObject fireballPrefab;
    public float spellSpeed = 20f;

    public void CastSpell(Vector3 direction)
    {
        GameObject spell = Instantiate(
            fireballPrefab,
            spellSpawnPoint.position,
            Quaternion.LookRotation(direction)
        );

        Rigidbody rb = spell.GetComponent<Rigidbody>();
        if (rb)
        {
            rb.linearVelocity = direction * spellSpeed;
        }
    }
}
