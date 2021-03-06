using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    [SerializeField] private double upperBound = 35;
    [SerializeField] private double lowerBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > upperBound || transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
