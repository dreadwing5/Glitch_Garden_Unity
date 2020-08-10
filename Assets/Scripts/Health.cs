using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float currentHealth = 500f;

    public void DealDamage(float damage){
        currentHealth-=damage;
        if(currentHealth<=0)
        {
            Die();
        }
    }

    public float SetHealth(){
        return currentHealth;
    }

    public void Die(){
        Debug.Log("Attacker is Dead!");
        Destroy(gameObject);
    }
   
}
