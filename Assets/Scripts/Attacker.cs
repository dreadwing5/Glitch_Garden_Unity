using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f,5f)]
    [SerializeField] float currentSpeed = 1f;

    void Update()
    {
        transform.Translate(Vector2.left *Time.deltaTime * currentSpeed); 
        /* The  Attacker starts moving form right to left on each frame, time.deltaTime is
        used to make the attacker speed framerate independent */
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }
}
