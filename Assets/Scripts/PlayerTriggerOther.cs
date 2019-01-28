using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerOther : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        // look for FinishTrigger instance on other gameObject
        FinishTrigger trigger = other.gameObject.GetComponent<FinishTrigger>();

        if (trigger != null)
        {
            trigger.LoadNextScene();
        }
    }

}
