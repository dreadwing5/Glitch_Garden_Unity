using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab, Gun;
    [SerializeField] float fireRate = 1f;
    public void Fire()
    {
       StartCoroutine(WaitAndFire());
    }

    IEnumerator WaitAndFire()
    {
        yield return new WaitForSeconds(fireRate);
        Instantiate(projectilePrefab,Gun.transform.position,Quaternion.identity);

    }
}
