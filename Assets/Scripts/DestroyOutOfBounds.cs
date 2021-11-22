using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float upperLim = 30f;
    private float lowerLim = -10f;

    void Update()
    {
        if(transform.position.z > upperLim)
        {
            Destroy(gameObject);
        }

        if(transform.position.z < lowerLim)
        {
            Destroy(gameObject);
        }
    }
}
