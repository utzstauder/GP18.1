using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {

    [SerializeField] float yRotation = 8;

    // Update is called once per frame
    void Update () {
        transform.Rotate(0, yRotation * Time.deltaTime, 0);
	}
}
