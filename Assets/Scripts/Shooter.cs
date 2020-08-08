using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab, Gun;
    [SerializeField] float moveSpeed =1f;
    public void Fire()
    {
        Instantiate(projectilePrefab,Gun.transform.position,transform.rotation);
    }
}
