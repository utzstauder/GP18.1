using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour {

    [SerializeField] float speed = 1;

    Vector2 inputDirection;

	// Update is called once per frame
	void Update () {
        // read and store input
        inputDirection.x = Input.GetAxisRaw("Horizontal");
        inputDirection.y = Input.GetAxisRaw("Vertical");

        // normalize input vector
        inputDirection.Normalize();

        // move transform
        transform.Translate(inputDirection.x * Time.deltaTime * speed,
                            0,
                            inputDirection.y * Time.deltaTime * speed);
	}
}
