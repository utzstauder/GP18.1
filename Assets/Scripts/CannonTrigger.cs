using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonTrigger : MonoBehaviour, ITriggerable {

    public void Trigger()
    {
        FireCannon();
    }

    private void FireCannon()
    {
        Debug.Log("Pew!");
    }

}
