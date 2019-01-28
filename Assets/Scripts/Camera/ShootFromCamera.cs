using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFromCamera : MonoBehaviour {

    Camera camera;

    private void Awake()
    {
        camera = GetComponent<Camera>();
    }

    void Update () {
	    if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }	
	}

    void Shoot()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            Debug.Log(hitInfo.collider.gameObject.name);

            IDamagable target = hitInfo.collider.gameObject.GetComponent<IDamagable>();
            if (target != null)
            {
                target.DoDamage(1);
            }
        }
    }
}
