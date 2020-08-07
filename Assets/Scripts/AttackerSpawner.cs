using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] GameObject attackerPrefab;
    [SerializeField] float maxSpawnDelay = 0f;
    [SerializeField] float minSpawnDelay = 5f;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay)); /* Wait Time To Spawn Attackers */
            SpawnAttacker();

        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnAttacker()
    {
        Instantiate(attackerPrefab,transform.position,Quaternion.identity);
        /* Instianting Attacker at a random wayPt */
    }
}
