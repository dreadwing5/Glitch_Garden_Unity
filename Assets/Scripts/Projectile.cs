﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float moveSpeed =1f;
    void Update()
    {
        transform.Translate(Vector2.right*Time.deltaTime*moveSpeed,Space.World);
    }
}