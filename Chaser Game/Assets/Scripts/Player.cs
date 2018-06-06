using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 10; // Speed -> number of meters traveled per second.

    // Update is called once per frame
    void Update () {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")); // Creating Vector3 struct and getting the X and Y axis input
        Vector3 direction = input.normalized; // To get the direction we need to normalize it. When normalized, a vector keeps the same direction but its length is 1.0
        Vector3 velocity = direction * speed; // Velocity -> number of meters traveled in a given direction per second
        Vector3 moveAmount = velocity * Time.deltaTime; // Move amount -> velocity * Time.deltaTime

        //transform.position += moveAmount; // Moving the player. Current position = current position + moveAmount
        transform.Translate(moveAmount); // Alternative way of doing the movement. More common.
    }
}
