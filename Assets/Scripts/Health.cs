using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float maxHealth = 500f;
    [SerializeField] float currentHealth = 0;
    void Start()
    {
        currentHealth = maxHealth;
    }
    void Update()
    {
        
    }
    public float UpdateHealth()
    {
        return currentHealth;
    }
}
