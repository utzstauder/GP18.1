using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBehaviour : MonoBehaviour {

    [SerializeField] GameObject projectilePrefab;
    [SerializeField] Transform spawnTransform;
    [SerializeField] float shotStrength = 10f;

    [SerializeField] float rotationSpeed = 2f;
    [SerializeField] Transform rotationPoint;

	// Update is called once per frame
	void Update () {
        // horizontal rotation
        transform.Rotate(0, Input.GetAxis("Mouse X") * rotationSpeed, 0);

        // vertical rotation
        rotationPoint.Rotate(-Input.GetAxis("Mouse Y"), 0, 0);

		if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (projectilePrefab == null)
        {
            Debug.LogError("No Prefab reference set.");
        }
        else
        {
            GameObject newObject = Instantiate(
                projectilePrefab,
                spawnTransform.position,
                spawnTransform.rotation
                );

            Rigidbody rb = newObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddRelativeForce(0, 0, shotStrength, ForceMode.Impulse);
            }
        }
    }
}
