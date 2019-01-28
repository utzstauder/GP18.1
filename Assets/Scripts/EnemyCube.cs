using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCube : MonoBehaviour, IDamagable {

    [SerializeField] int maxHp;
    int currentHp;

    void Start () {
        currentHp = maxHp;
	}

    void Defeat()
    {
        Destroy(gameObject);
    }

    public void DoDamage(int damageAmount)
    {
        currentHp -= damageAmount;

        if (currentHp <= 0)
        {
            Defeat();
        }

        // TODO: cooldown / invincibility time
    }
}
