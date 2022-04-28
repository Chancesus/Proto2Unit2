using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float fireDelay = 1;

    
    void Update()
    {
        //Increment Timer
        fireDelay += Time.deltaTime;
        //Spawn Dog and Reset Timer
        if (Input.GetKeyDown(KeyCode.Space) && fireDelay >= 3)
        {
            SpawnDog();
            fireDelay = 0;
        }
    }

    private void SpawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }

    
}
