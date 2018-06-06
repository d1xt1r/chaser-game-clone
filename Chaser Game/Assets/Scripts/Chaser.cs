using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour {

    public Transform targetTransform; // Reference to the Player object transform. Usable in Unity Inspector by assining the Player transform to this variable.
    public float speed = 7f;

	// Update is called once per frame
	void Update () {
        Vector3 displacementFromTarget = targetTransform.position - transform.position; // Calculating the displacement between the Player and our own object (Chaser).
        Vector3 directionToTarget = displacementFromTarget.normalized; // Getting the direction towards the target
        Vector3 velocity = directionToTarget * speed; // Velocity -> number of meters traveled in a given direction per second
        Vector3 moveAmount = velocity * Time.deltaTime; // Move amount -> velocity * Time.deltaTime

        float distanceToTarget = displacementFromTarget.magnitude; // Set a distance from the target. Magnitude -> the distance between the vector's origin (0,0,0) and its endpoint

        if(distanceToTarget > 1.5f) { // Only if distance is greater than 1.5 then move the objet towards the target.
            transform.Translate(moveAmount); // Moving the player.
        }
        
    }
}
