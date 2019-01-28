using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerOther : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        //// look for a single interface on other gameObject
        //ITriggerable trigger = other.gameObject.GetComponent<ITriggerable>();
        //if (trigger != null)
        //{
        //    trigger.Trigger();
        //}

        // look for ALL ITriggerable instances on other gameObject
        ITriggerable[] triggers = other.gameObject.GetComponents<ITriggerable>();
        for (int i = 0; i < triggers.Length; i++)
        {
            triggers[i].Trigger();
        }


        // look for FinishTrigger instance on other gameObject
        //FinishTrigger finishTrigger = other.gameObject.GetComponent<FinishTrigger>();

        //if (finishTrigger != null)
        //{
        //    finishTrigger.LoadNextScene();
        //}


        //CannonTrigger cannonTrigger = other.gameObject.GetComponent<CannonTrigger>();

        //if (cannonTrigger != null)
        //{
        //    cannonTrigger.FireCannon();
        //}
    }

}
