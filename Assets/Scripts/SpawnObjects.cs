using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

    [SerializeField] GameObject prefab;
    [SerializeField] int amount;
    [SerializeField] int amountPerRow;
    [SerializeField] Vector3 rowOffset;
    [SerializeField] Vector3 columnOffset;

	// Use this for initialization
	void Start () {
        Spawn();
	}
	
    void Spawn()
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject newObject = Instantiate(prefab, transform);
            newObject.transform.localPosition =
                rowOffset * (i % amountPerRow) +
                columnOffset * (i / amountPerRow);
        }
    }
}
