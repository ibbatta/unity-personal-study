using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 250f;
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float slowSpeed = 5f;
    [SerializeField] float boostSpeed = 25f;
    [SerializeField] float regularSpeed = 15f;


    
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * -1 * Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, speedAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D other) {

        switch (other.tag)
        {
            case "Boost":
                Debug.Log("--- Wanna see some real speed?");
                moveSpeed = boostSpeed;
                break;

            case "Bump":
                Debug.Log("--- Slow down dude!");
                 moveSpeed = slowSpeed;
                break;

            case "Package":
                Debug.Log("--- Regular speed incoming");
                moveSpeed = regularSpeed;
                break;
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
    }

}
