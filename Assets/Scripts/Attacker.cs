﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f,5f)]
    [SerializeField] float currentSpeed = 1f;
    [SerializeField] float maxHealth = 500f;
    public float currentHealth = 0f;
    void Start() {
        currentHealth = maxHealth;        
    }

    void Update()
    {
        transform.Translate(Vector2.left *Time.deltaTime * currentSpeed); 
        /* The  Attacker starts moving form right to left on each frame, time.deltaTime is
        used to make the attacker speed framerate independent */
    }

    public void SetMovementSpeed(float speed)//Recieving Speed from Animator window 
    {
        currentSpeed = speed;
    }

 /*   private void CheckForDeath(){
        if(currentHealth<=0)
        {
            Die();
        }
    }
    private void Die(){
        Destroy(gameObject); //Destroy the Attacker if the current health drops below Zero
    } */
}