using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] public float damageDealt = 100f;
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.GetComponent<Attacker>())
        {
            var health = otherCollider.gameObject.GetComponent<Health>();
            if (!health) { return; }
            health.DealDamage(damageDealt);
            Destroy(gameObject);

        }
    }
}
