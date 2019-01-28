using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(collision.gameObject);
        //Debug.Log(collision.contacts[0].point);

        Destroy(gameObject);
    }

}
