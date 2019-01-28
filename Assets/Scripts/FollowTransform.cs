using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTransform : MonoBehaviour {

    [SerializeField] Transform targetTransform;
    [SerializeField] float smoothStep = 0.5f;

	// Use this for initialization
	void Start () {
		if (targetTransform == null)
        {
            enabled = false;
            Debug.LogError("Please reference a valid Transform component");
        }
	}
	
	// Update is called once per frame
	void Update () {
        // transform.position = targetTransform.position;

        transform.position = Vector3.Lerp(
            transform.position,
            targetTransform.position,
            smoothStep * Time.deltaTime
            );
	}
}
