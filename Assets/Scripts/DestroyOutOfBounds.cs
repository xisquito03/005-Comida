using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float upperLimit = 20;
    public float lowerLimit = -10f;


    private void Update()
    {
        if (transform.position.z > upperLimit) {
            Destroy(gameObject);

        }
        else if (transform.position.z < lowerLimit)
        {
            Destroy(gameObject);
        }
    }
}
