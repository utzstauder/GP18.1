using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControllerRigidbody : MonoBehaviour {

    [SerializeField] float speed = 1;

    Vector2 inputDirection;
    Rigidbody rb;

    private void Awake()
    {
        // find Rigidbody Component on this GameObject
        rb = GetComponent<Rigidbody>();

        // check if we did not find one
        if (rb == null)
        {
            // option A: add Rigidbody component
            // rb = gameObject.AddComponent<Rigidbody>();
            // BAD

            // option B1: log error
            Debug.LogError("Did not find Rigidbody. Please fix this.");
            // GOOD

            // option B2: disable script
            enabled = false;
        }

    }

    // Update is called once per frame
    void Update () {
        // read and store input
        inputDirection.x = Input.GetAxis("Horizontal");
        inputDirection.y = Input.GetAxis("Vertical");

        // normalize input vector
        inputDirection.Normalize();
    }

    private void FixedUpdate()
    {
        // pass speed and direction into rigidbody
        rb.velocity = new Vector3(
                inputDirection.x * speed,
                rb.velocity.y,
                inputDirection.y * speed
            );
    }
}
