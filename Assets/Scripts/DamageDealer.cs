using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    Attacker attacker;
    [SerializeField] float damageDone = 100f;
    void Start()
    {
        attacker = FindObjectOfType<Attacker>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        InflictDamage();
    }
    /* private void OnTriggerEnter(Collider other) {
        if(other.gameObject.GetComponent<Attacker>())
        {
            InflictDamage(); //As soon as projectile collides with attacker , the attacker health drops down based on the damageDone

        }

    } */

    public void InflictDamage()
    {
        // attacker.currentHealth-=damageDone;
        Debug.Log("Damage Received");
    }
}
